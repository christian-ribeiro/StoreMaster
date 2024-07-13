using StockEase.Domain.DTO.Base;

namespace StockEase.Domain.DTO
{
    public class InternalPropertiesLanguageDTO : BaseInternalPropertiesDTO<InternalPropertiesLanguageDTO>
    {
        public string Code { get; private set; }
        public string Description { get; private set; }

        public InternalPropertiesLanguageDTO() { }

        public InternalPropertiesLanguageDTO(string code, string description)
        {
            Code = code;
            Description = description;
        }
    }
}