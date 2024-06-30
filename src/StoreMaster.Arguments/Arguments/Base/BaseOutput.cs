namespace StoreMaster.Arguments.Arguments.Base
{
    public class BaseOutput<TOutput> where TOutput : BaseOutput<TOutput>
    {
        public long Id { get; set; }
        public virtual DateTime CreationDate { get; set; }
        public virtual DateTime? ChangeDate { get; set; }

        public TOutput SetInternalData(long id, DateTime creationDate, DateTime? changeDate)
        {
            Id = id;
            CreationDate = creationDate;
            ChangeDate = changeDate;
            return (TOutput)this;
        }
    }
}
