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
        #endregion

        public string Code { get; set; }
        public string Description { get; set; }

        #region Virtual Properties
        #region External
        public List<OutputUser> ListUser { get; set; }
        #endregion
        #endregion

        public OutputUserStatus(string code, string description, List<OutputUser> listUser)
        {
            Code = code;
            Description = description;
            ListUser = listUser;
        }
    }
}