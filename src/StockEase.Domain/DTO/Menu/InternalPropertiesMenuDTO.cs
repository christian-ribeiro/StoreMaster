using StockEase.Domain.DTO.Base;

namespace StockEase.Domain.DTO
{
    public class InternalPropertiesMenuDTO : BaseInternalPropertiesDTO<InternalPropertiesMenuDTO>
    {
        public string Path { get; private set; }
        public string Label { get; private set; }
        public int Position { get; private set; }
        public bool Visible { get; private set; }
        public string? ToolTip { get; private set; }
        public long? ParentId { get; private set; }

        public InternalPropertiesMenuDTO() { }

        public InternalPropertiesMenuDTO(string path, string label, int position, bool visible, string? toolTip, long? parentId)
        {
            Path = path;
            Label = label;
            Position = position;
            Visible = visible;
            ToolTip = toolTip;
            ParentId = parentId;
        }
    }
}