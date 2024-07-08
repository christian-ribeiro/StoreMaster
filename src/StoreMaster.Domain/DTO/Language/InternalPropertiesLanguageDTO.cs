using StoreMaster.Domain.DTO.Base;

namespace StoreMaster.Domain.DTO
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