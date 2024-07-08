using Microsoft.IdentityModel.Tokens;
using StoreMaster.Arguments;
using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.DTO;
using StoreMaster.Domain.Extensions;
using StoreMaster.Domain.Interface.Repository;
using StoreMaster.Domain.Interface.Service;
using System.Text.RegularExpressions;

namespace StoreMaster.Domain.Service
{
    public class AuthenticationService(IUserRepository userRepository, ILanguageRepository languageRepository) : IAuthenticationService
    {
        private static readonly Regex EmailRegex = new Regex(
        @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
        RegexOptions.Compiled | RegexOptions.IgnoreCase);

        private readonly IUserRepository _userRepository = userRepository;
        private readonly ILanguageRepository _languageRepository = languageRepository;

        public OutputAuthenticationUser SignIn(InputAuthenticationUser inputAuthenticationUser)
        {
            UserDTO originalUserDTO = _userRepository.GetByIdentifier(new InputIdentifierUser(inputAuthenticationUser.Email));

            if (originalUserDTO == null)
                throw new ArgumentNullException("Usuário ou senha inválidos");

            if (!originalUserDTO.ExternalPropertiesDTO.Password.VerifyPassword(inputAuthenticationUser.Password))
                throw new ArgumentNullException("Usuário ou senha inválidos");

            string token = TokenExtension.GenerateJwtToken(originalUserDTO);

            return new OutputAuthenticationUser(originalUserDTO.InternalPropertiesDTO.Id, originalUserDTO.ExternalPropertiesDTO.Code, originalUserDTO.ExternalPropertiesDTO.Name, originalUserDTO.ExternalPropertiesDTO.Email, token, originalUserDTO.AuxiliaryPropertiesDTO.Language, originalUserDTO.AuxiliaryPropertiesDTO.UserStatus);
        }

        public long Register(InputRegisterAuthenticationUser inputRegisterAuthenticationUser)
        {
            UserDTO originalUserDTO = _userRepository.GetByIdentifier(new InputIdentifierUser(inputRegisterAuthenticationUser.Email));

            if (originalUserDTO != null)
                throw new InvalidOperationException("E-mail já utilizado");

            if (string.IsNullOrEmpty(inputRegisterAuthenticationUser.Code))
                throw new ArgumentNullException("Informe o código");

            if (!EmailRegex.IsMatch(inputRegisterAuthenticationUser.Email))
                throw new InvalidOperationException("Informe um e-mail válido");

            LanguageDTO languageDTO = _languageRepository.Get(inputRegisterAuthenticationUser.LanguageId);

            if (languageDTO == null)
                throw new ArgumentNullException("Idioma não encontrado");

            if (string.IsNullOrEmpty(inputRegisterAuthenticationUser.Password))
                throw new ArgumentNullException("Preencha a senha");

            if (!inputRegisterAuthenticationUser.Password.Equals(inputRegisterAuthenticationUser.ConfirmPassword))
                throw new InvalidOperationException("Senhas não conferem");

            UserDTO userDTO = new UserDTO().Create(new InputCreateUser(inputRegisterAuthenticationUser.Code, inputRegisterAuthenticationUser.Name, inputRegisterAuthenticationUser.Password.HashPassword(), inputRegisterAuthenticationUser.ConfirmPassword, inputRegisterAuthenticationUser.Email, inputRegisterAuthenticationUser.LanguageId, 1));

            return _userRepository.Create(userDTO);
        }
    }
}