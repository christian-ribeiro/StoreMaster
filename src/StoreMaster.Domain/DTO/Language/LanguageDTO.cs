using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.DTO.Base;
using StoreMaster.Domain.Extensions;

namespace StoreMaster.Domain.DTO
{
    public class LanguageDTO : BaseDTO_2<OutputLanguage, InputIdentifierLanguage, LanguageDTO, InternalPropertiesLanguageDTO, AuxiliaryPropertiesLanguageDTO>
    {
#nullable disable
        public static LanguageDTO GetDTO(OutputLanguage output)
        {
            return output == null ? default : new LanguageDTO().Load(
                new InternalPropertiesLanguageDTO(output.Code, output.Description).SetInternalData(output.Id, output.CreationDate, output.ChangeDate),
                default,
                new AuxiliaryPropertiesLanguageDTO(output.ListUser.ConvertAll<UserDTO>()));
        }

        public static OutputLanguage GetOutput(LanguageDTO dto)
        {
            return dto == null ? default : new OutputLanguage(dto.InternalPropertiesDTO.Code, dto.InternalPropertiesDTO.Description, dto.AuxiliaryPropertiesDTO.ListUser.ConvertAll<OutputUser>())
                .SetInternalData(dto.InternalPropertiesDTO.Id, dto.InternalPropertiesDTO.CreationDate, dto.InternalPropertiesDTO.ChangeDate);
        }

        public static implicit operator LanguageDTO(OutputLanguage output)
        {
            return GetDTO(output);
        }

        public static implicit operator OutputLanguage(LanguageDTO dto)
        {
            return GetOutput(dto);
        }
#nullable enable
    }
}