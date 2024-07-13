namespace StockEase.Arguments.Arguments.Base
{
    public class BaseInputIdentityUpdate<TInputUpdate> where TInputUpdate : BaseInputUpdate<TInputUpdate>
    {
        public long Id { get; set; }
        public TInputUpdate? InputUpdate { get; set; }

        public BaseInputIdentityUpdate() { }

        public BaseInputIdentityUpdate(long id, TInputUpdate? inputUpdate)
        {
            Id = id;
            InputUpdate = inputUpdate;
        }
    }

    public class BaseInputIdentityUpdate_0 : BaseInputIdentityUpdate<BaseInputUpdate_0> { }
}