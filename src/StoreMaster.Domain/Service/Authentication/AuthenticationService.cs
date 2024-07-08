using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.DTO;
using StoreMaster.Domain.Extensions;
using StoreMaster.Domain.Interface.Repository;
using StoreMaster.Domain.Interface.Service;

namespace StoreMaster.Domain.Service
{
    public class AuthenticationService(IUserRepository userRepository) : IAuthenticationService
    {

        private readonly IUserRepository _userRepository = userRepository;

        public OutputAuthenticationUser SignIn(InputAuthenticationUser inputAuthenticationUser)
        {
            UserDTO originalUserDTO = _userRepository.GetByIdentifier(new InputIdentifierUser(inputAuthenticationUser.Email));

            if (originalUserDTO == null)
                throw new ArgumentNullException("Usuário ou senha inválidos");

            if(!originalUserDTO.ExternalPropertiesDTO.Password.VerifyPassword(inputAuthenticationUser.Password))
                throw new ArgumentNullException("Usuário ou senha inválidos");

            string token = TokenExtension.GenerateJwtToken(originalUserDTO);

            return new OutputAuthenticationUser(originalUserDTO.InternalPropertiesDTO.Id, originalUserDTO.ExternalPropertiesDTO.Code, originalUserDTO.ExternalPropertiesDTO.Name, originalUserDTO.ExternalPropertiesDTO.Email, token, originalUserDTO.AuxiliaryPropertiesDTO.Language, originalUserDTO.AuxiliaryPropertiesDTO.UserStatus);
        }
    }
}