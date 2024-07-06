using StoreMaster.Arguments.Arguments.Base;
using System.Text.Json.Serialization;

namespace StoreMaster.Arguments.Arguments
{
    public class OutputStockMovementType : BaseOutput<OutputStockMovementType>
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
        public List<OutputStockMovement> ListOutputStockMovement { get; set; }
        #endregion
        #endregion

        public OutputStockMovementType() { }

        public OutputStockMovementType(string code, string description, List<OutputStockMovement> listOutputStockMovement)
        {
            Code = code;
            Description = description;
            ListOutputStockMovement = listOutputStockMovement;
        }
    }
}