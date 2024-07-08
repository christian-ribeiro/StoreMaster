using StoreMaster.Arguments.Arguments.Base;
using System.Text.Json.Serialization;

namespace StoreMaster.Arguments.Arguments
{
    public class OutputUserStatus : BaseOutput<OutputUserStatus>
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

        public string Code { get; set; }
        public string Description { get; set; }

        public OutputUserStatus(string code, string description)
        {
            Code = code;
            Description = description;
        }
    }
}