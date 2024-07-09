using StoreMaster.Domain.DTO.Base;

namespace StoreMaster.Domain.DTO
{
    public class InternalPropertiesStockMovementDTO : BaseInternalPropertiesDTO<InternalPropertiesStockMovementDTO>
    {
        public int Sequence { get; private set; }

        public InternalPropertiesStockMovementDTO() { }

        public InternalPropertiesStockMovementDTO(int sequence)
        {
            Sequence = sequence;
        }
    }
}