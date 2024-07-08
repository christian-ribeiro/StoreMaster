namespace StoreMaster.Infrastructure.Persistence.Entry.Base
{
    public class BaseEntry<TEntry> where TEntry : BaseEntry<TEntry>
    {
        public long Id { get; private set; }
        public virtual DateTime CreationDate { get; private set; }
        public virtual DateTime? ChangeDate { get; private set; }
        public virtual long CreationUserId { get; private set; }
        public virtual long? ChangeUserId { get; private set; }

        #region Virtual Properties
        #region Internal
        public virtual User? CreationUser { get; private set; }
        public virtual User? ChangeUser { get; private set; }
        #endregion
        #endregion

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

        public TEntry SetInternalData(long id, DateTime creationDate, DateTime? changeDate, long creationUserId, long? changeUserId, User? creationUser, User? changeUser)
        {
            Id = id;
            CreationDate = creationDate;
            ChangeDate = changeDate;
            CreationUserId = creationUserId;
            ChangeUserId = changeUserId;
            CreationUser = creationUser;
            ChangeUser = changeUser;
            return (TEntry)this;
        }

        public TEntry SetInternalDataCreate(DateTime creationDate, long creationUserId, User? creationUser)
        {
            CreationDate = creationDate;
            CreationUserId = creationUserId;
            CreationUser = creationUser;
            return (TEntry)this;
        }

        public TEntry SetInternalDataChange(DateTime? changeDate, long? changeUserId, User? changeUser)
        {
            ChangeDate = changeDate;
            ChangeUserId = changeUserId;
            ChangeUser = changeUser;
            return (TEntry)this;
        }

        public TEntry SetInternalData(long id)
        {
            Id = id;
            return (TEntry)this;
        }
    }
}