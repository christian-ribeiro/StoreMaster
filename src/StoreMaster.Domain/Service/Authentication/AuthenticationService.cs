using StoreMaster.Arguments;
using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.DTO;
using StoreMaster.Domain.Extensions;
using StoreMaster.Domain.Interface.Repository;
using StoreMaster.Domain.Interface.Service;
using System.Security.Claims;
using System.Text.RegularExpressions;

namespace StoreMaster.Domain.Service
{
    public class AuthenticationService(IUserRepository userRepository, ILanguageRepository languageRepository) : IAuthenticationService
    {
        private static readonly Regex EmailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled | RegexOptions.IgnoreCase);

        private readonly IUserRepository _userRepository = userRepository;
        private readonly ILanguageRepository _languageRepository = languageRepository;

        public OutputAuthentication Login(InputAuthentication inputAuthentication)
        {
            UserDTO originalUserDTO = _userRepository.GetByIdentifier(new InputIdentifierUser(inputAuthentication.Email));

            if (originalUserDTO == null)
                throw new ArgumentNullException("Usuário ou senha inválidos");

            if (!originalUserDTO.ExternalPropertiesDTO.Password.VerifyPassword(inputAuthentication.Password))
                throw new ArgumentNullException("Usuário ou senha inválidos");

            string token = TokenExtension.GenerateJwtToken(originalUserDTO);
            string refreshToken = TokenExtension.GenerateRefreshToken();

            originalUserDTO.InternalPropertiesDTO.SetProperty(nameof(originalUserDTO.InternalPropertiesDTO.RefreshToken), refreshToken);

            _userRepository.Update(originalUserDTO);

            return new OutputAuthentication(originalUserDTO.InternalPropertiesDTO.Id, originalUserDTO.ExternalPropertiesDTO.Code, originalUserDTO.ExternalPropertiesDTO.Name, originalUserDTO.ExternalPropertiesDTO.Email, token, refreshToken, originalUserDTO.AuxiliaryPropertiesDTO.Language, originalUserDTO.AuxiliaryPropertiesDTO.UserStatus);
        }

        public OutputAuthentication RefreshToken(InputRefreshTokenAuthentication inputRefreshTokenAuthentication)
        {
            ClaimsPrincipal principal = TokenExtension.GetPrincipalFromExpiredToken(inputRefreshTokenAuthentication.Token);
            long userId = Convert.ToInt64(principal.FindFirst("UserId").Value);

            UserDTO originalUserDTO = _userRepository.Get(userId);

            if (originalUserDTO == null)
                throw new ArgumentNullException("Usuário ou senha inválidos");

            if (originalUserDTO.InternalPropertiesDTO.RefreshToken != inputRefreshTokenAuthentication.RefreshToken)
                throw new InvalidOperationException("Refresh Token Inválido");

            string token = TokenExtension.GenerateJwtToken(principal.Claims.ToList());
            string refreshToken = TokenExtension.GenerateRefreshToken();

            originalUserDTO.InternalPropertiesDTO.SetProperty(nameof(originalUserDTO.InternalPropertiesDTO.RefreshToken), refreshToken);

            _userRepository.Update(originalUserDTO);

            return new OutputAuthentication(originalUserDTO.InternalPropertiesDTO.Id, originalUserDTO.ExternalPropertiesDTO.Code, originalUserDTO.ExternalPropertiesDTO.Name, originalUserDTO.ExternalPropertiesDTO.Email, token, refreshToken, originalUserDTO.AuxiliaryPropertiesDTO.Language, originalUserDTO.AuxiliaryPropertiesDTO.UserStatus);
        }

        public long Register(InputRegisterAuthentication inputRegisterAuthentication)
        {
            UserDTO originalUserDTO = _userRepository.GetByIdentifier(new InputIdentifierUser(inputRegisterAuthentication.Email));

            if (originalUserDTO != null)
                throw new InvalidOperationException("E-mail já utilizado");

            if (string.IsNullOrEmpty(inputRegisterAuthentication.Code))
                throw new ArgumentNullException("Informe o código");

            if (!EmailRegex.IsMatch(inputRegisterAuthentication.Email))
                throw new InvalidOperationException("Informe um e-mail válido");

            LanguageDTO languageDTO = _languageRepository.Get(inputRegisterAuthentication.LanguageId);

            if (languageDTO == null)
                throw new ArgumentNullException("Idioma não encontrado");

            if (string.IsNullOrEmpty(inputRegisterAuthentication.Password))
                throw new ArgumentNullException("Preencha a senha");

            if (!inputRegisterAuthentication.Password.Equals(inputRegisterAuthentication.ConfirmPassword))
                throw new InvalidOperationException("Senhas não conferem");

            UserDTO userDTO = new UserDTO().Create(new InputCreateUser(inputRegisterAuthentication.Code, inputRegisterAuthentication.Name, inputRegisterAuthentication.Password.HashPassword(), inputRegisterAuthentication.ConfirmPassword, inputRegisterAuthentication.Email, inputRegisterAuthentication.LanguageId, 1));

            return _userRepository.Create(userDTO);
        }
    }
}