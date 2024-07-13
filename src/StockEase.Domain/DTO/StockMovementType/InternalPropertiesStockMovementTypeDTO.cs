using StockEase.Domain.DTO.Base;

namespace StockEase.Domain.DTO
{
    public class InternalPropertiesStockMovementTypeDTO : BaseInternalPropertiesDTO<InternalPropertiesStockMovementTypeDTO>
    {
        public string Code { get; private set; }
        public string Description { get; private set; }

        public InternalPropertiesStockMovementTypeDTO() { }

        public InternalPropertiesStockMovementTypeDTO(string code, string description)
        {
            Code = code;
            Description = description;
        }
    }
}