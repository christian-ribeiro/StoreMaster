namespace StoreMaster.Domain.DTO.Base
{
    public abstract class BaseInternalPropertiesDTO<TInternalPropertiesDTO> where TInternalPropertiesDTO : BaseInternalPropertiesDTO<TInternalPropertiesDTO>, new()
    {
        public long Id { get; set; }
        public virtual DateTime CreationDate { get; set; }
        public virtual DateTime? ChangeDate { get; set; }

        public TInternalPropertiesDTO SetInternalData(long id, DateTime creationDate, DateTime? changeDate)
        {
            Id = id;
            CreationDate = creationDate;
            ChangeDate = changeDate;
            return (TInternalPropertiesDTO)this;
        }

        public TInternalPropertiesDTO SetInternalData(long id)
        {
            Id = id;
            return (TInternalPropertiesDTO)this;
        }

        public TInternalPropertiesDTO SetCreateData()
        {
            CreationDate = DateTime.Now;
            return (TInternalPropertiesDTO)this;
        }

        public TInternalPropertiesDTO SetUpdateData()
        {
            ChangeDate = DateTime.Now;
            return (TInternalPropertiesDTO)this;
        }
    }
}