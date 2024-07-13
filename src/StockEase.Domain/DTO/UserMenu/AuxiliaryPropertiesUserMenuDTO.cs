using StockEase.Domain.DTO.Base;

namespace StockEase.Domain.DTO
{
    public class AuxiliaryPropertiesUserMenuDTO : BaseAuxiliaryPropertiesDTO<AuxiliaryPropertiesUserMenuDTO>
    {
        public MenuDTO? Menu { get; private set; }

        public AuxiliaryPropertiesUserMenuDTO() { }

        public AuxiliaryPropertiesUserMenuDTO(MenuDTO? menu)
        {
            Menu = menu;
        }
    }
}