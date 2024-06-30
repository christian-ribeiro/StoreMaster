namespace StoreMaster.Domain.DTO.Base
{
    public abstract class BaseInternalPropertiesDTO<TInternalProperties> where TInternalProperties : BaseInternalPropertiesDTO<TInternalProperties>, new()
    {
        public long Id { get; set; }
        public virtual DateTime CreationDate { get; set; }
        public virtual DateTime? ChangeDate { get; set; }

        public TInternalProperties SetInternalData(long id, DateTime creationDate, DateTime? changeDate)
        {
            Id = id;
            CreationDate = creationDate;
            ChangeDate = changeDate;
            return (TInternalProperties)this;
        }
    }
}