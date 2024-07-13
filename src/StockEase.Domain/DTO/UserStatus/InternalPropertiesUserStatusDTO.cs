using StockEase.Domain.DTO.Base;

namespace StockEase.Domain.DTO
{
    public class InternalPropertiesUserStatusDTO : BaseInternalPropertiesDTO<InternalPropertiesUserStatusDTO>
    {
        public string Code { get; private set; }
        public string Description { get; private set; }

        public InternalPropertiesUserStatusDTO() { }

        public InternalPropertiesUserStatusDTO(string code, string description)
        {
            Code = code;
            Description = description;
        }
    }
}