using StoreMaster.Arguments.Arguments.Base;
using System.Text.Json.Serialization;

namespace StoreMaster.Arguments.Arguments
{
    public class OutputMenu : BaseOutput<OutputMenu>
    {
        #region Ignore
        [JsonIgnore]
        public override DateTime? ChangeDate { get => base.ChangeDate; set => base.ChangeDate = value; }
        [JsonIgnore]
        public override DateTime CreationDate { get => base.CreationDate; set => base.CreationDate = value; }
        [JsonIgnore]
        public override long CreationUserId { get => base.CreationUserId; set => base.CreationUserId = value; }
        [JsonIgnore]
        public override long? ChangeUserId { get => base.ChangeUserId; set => base.ChangeUserId = value; }
        [JsonIgnore]
        public override OutputUser CreationUser { get => base.CreationUser; set => base.CreationUser = value; }
        [JsonIgnore]
        public override OutputUser ChangeUser { get => base.ChangeUser; set => base.ChangeUser = value; }
        #endregion
        public string Path { get; set; }
        public string Label { get; set; }
        public int Position { get; set; }
        public bool Visible { get; set; }
        public string? ToolTip { get; set; }
        public long? ParentId { get; set; }

        public OutputMenu() { }

        public OutputMenu(string path, string label, int position, bool visible, string? toolTip, long? parentId)
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