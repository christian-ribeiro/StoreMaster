using System.ComponentModel.DataAnnotations.Schema;

namespace StoreMaster.Infrastructure.Persistence.Entry.Base
{
    public class BaseEntry<TEntry> where TEntry : BaseEntry<TEntry>
    {
        public long Id { get; set; }
        [NotMapped]
        public virtual DateTime CreationDate { get; set; }
        [NotMapped]
        public virtual DateTime? ChangeDate { get; set; }

        public TEntry SetCreateData()
        {
            CreationDate = DateTime.Now;
            return (TEntry)this;
        }

        public TEntry SetChangeData()
        {
            ChangeDate = DateTime.Now;
            return (TEntry)this;
        }

        public TEntry SetInternalData(long id, DateTime creationDate, DateTime? changeDate)
        {
            Id = id;
            CreationDate = creationDate;
            ChangeDate = changeDate;
            return (TEntry)this;
        }
    }
}