namespace StockEase.Arguments.Arguments.Base
{
    public class BaseInputIdentityDelete<TInputIdentityDelete> where TInputIdentityDelete : BaseInputIdentityDelete<TInputIdentityDelete>
    {
        public long Id { get; set; }

        public BaseInputIdentityDelete() { }

        public BaseInputIdentityDelete(long id)
        {
            Id = id;
        }
    }

    public class BaseInputIdentityDelete_0 : BaseInputIdentityDelete<BaseInputIdentityDelete_0> { }
}