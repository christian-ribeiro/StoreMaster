namespace StoreMaster.Arguments.Arguments.Base
{
    public class BaseOutput<TOutput> where TOutput : BaseOutput<TOutput>
    {
        public long Id { get; set; }
        public virtual DateTime CreationDate { get; set; }
        public virtual DateTime? ChangeDate { get; set; }
        public virtual long CreationUserId { get; set; }
        public virtual long? ChangeUserId { get; set; }
        public virtual OutputUser CreationUser { get; set; }
        public virtual OutputUser ChangeUser { get; set; }

        public TOutput SetInternalData(long id, DateTime creationDate, DateTime? changeDate, long creationUserId, long? changeUserId, OutputUser creationUser, OutputUser changeUser)
        {
            Id = id;
            CreationDate = creationDate;
            ChangeDate = changeDate;
            CreationUserId = creationUserId;
            ChangeUserId = changeUserId;
            CreationUser = creationUser;
            ChangeUser = changeUser;
            return (TOutput)this;
        }

        public TOutput SetInternalDataCreate(DateTime creationDate, long creationUserId, OutputUser creationUser)
        {
            CreationDate = creationDate;
            CreationUserId = creationUserId;
            CreationUser = creationUser;
            return (TOutput)this;
        }

        public TOutput SetInternalDataChange(DateTime? changeDate, long? changeUserId, OutputUser changeUser)
        {
            ChangeDate = changeDate;
            ChangeUserId = changeUserId;
            ChangeUser = changeUser;
            return (TOutput)this;
        }

        public TOutput SetInternalData(long id)
        {
            Id = id;
            return (TOutput)this;
        }
    }
}
