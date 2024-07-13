using StockEase.Domain.DTO.Base;

namespace StockEase.Domain.DTO
{
    public class ExternalPropertiesProductCategoryDTO : BaseExternalPropertiesDTO<ExternalPropertiesProductCategoryDTO>
    {
        public string Code { get; private set; }
        public string Description { get; private set; }

        public ExternalPropertiesProductCategoryDTO() { }

        public ExternalPropertiesProductCategoryDTO(string code, string description)
        {
            Code = code;
            Description = description;
        }
    }
}