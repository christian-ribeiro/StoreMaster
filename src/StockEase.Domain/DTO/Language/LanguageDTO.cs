using StockEase.Arguments.Arguments;
using StockEase.Domain.DTO.Base;

namespace StockEase.Domain.DTO
{
    public class LanguageDTO : BaseDTO_3<OutputLanguage, InputIdentifierLanguage, LanguageDTO, InternalPropertiesLanguageDTO, AuxiliaryPropertiesLanguageDTO>
    {
#nullable disable
        public static LanguageDTO GetDTO(OutputLanguage output)
        {
            return output == null ? default : new LanguageDTO().Load(
                new InternalPropertiesLanguageDTO(output.Code, output.Description).SetInternalData(output.Id),
                default,
                new AuxiliaryPropertiesLanguageDTO());
        }

        public static OutputLanguage GetOutput(LanguageDTO dto)
        {
            return dto == null ? default : new OutputLanguage(dto.InternalPropertiesDTO.Code, dto.InternalPropertiesDTO.Description)
                .SetInternalData(dto.InternalPropertiesDTO.Id);
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