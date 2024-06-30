using StoreMaster.Domain.DTO.Base;

namespace StoreMaster.Domain.DTO
{
    public class ExternalPropertiesProductDTO : BaseExternalPropertiesDTO<ExternalPropertiesProductDTO>
    {
        public long ProductCategoryId { get; private set; }

        public ExternalPropertiesProductDTO() { }

        public ExternalPropertiesProductDTO(long productCategoryId)
        {
            ProductCategoryId = productCategoryId;
        }
    }
}