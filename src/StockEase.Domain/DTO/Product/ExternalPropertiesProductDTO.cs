using StockEase.Domain.DTO.Base;

namespace StockEase.Domain.DTO
{
    public class ExternalPropertiesProductDTO : BaseExternalPropertiesDTO<ExternalPropertiesProductDTO>
    {
        public string Description { get; private set; }
        public long ProductCategoryId { get; private set; }

        public ExternalPropertiesProductDTO() { }

        public ExternalPropertiesProductDTO(string description, long productCategoryId)
        {
            Description = description;
            ProductCategoryId = productCategoryId;
        }
    }
}