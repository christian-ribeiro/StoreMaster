using StoreMaster.Arguments.Arguments.Base;
using System.Text.Json.Serialization;

namespace StoreMaster.Arguments.Arguments
{
    public class OutputLanguage : BaseOutput<OutputLanguage>
    {
        #region Ignore
        [JsonIgnore]
        public override DateTime? ChangeDate { get => base.ChangeDate; set => base.ChangeDate = value; }
        [JsonIgnore]
        public override DateTime CreationDate { get => base.CreationDate; set => base.CreationDate = value; }
        #endregion

        public string Code { get; set; }
        public string Description { get; set; }

        public OutputLanguage(string code, string description)
        {
            Code = code;
            Description = description;
        }
    }
}