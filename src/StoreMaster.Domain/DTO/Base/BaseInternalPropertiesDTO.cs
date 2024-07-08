using StoreMaster.Arguments;

namespace StoreMaster.Domain.DTO.Base
{
    public abstract class BaseInternalPropertiesDTO<TInternalPropertiesDTO> where TInternalPropertiesDTO : BaseInternalPropertiesDTO<TInternalPropertiesDTO>, new()
    {
        public long Id { get; private set; }
        public virtual DateTime CreationDate { get; private set; }
        public virtual DateTime? ChangeDate { get; private set; }
        public virtual long CreationUserId { get; private set; }
        public virtual long? ChangeUserId { get; private set; }

        public TInternalPropertiesDTO SetInternalData(long id, DateTime creationDate, DateTime? changeDate, long creationUserId, long? changeUserId)
        {
            Id = id;
            CreationDate = creationDate;
            ChangeDate = changeDate;
            CreationUserId = creationUserId;
            ChangeUserId = changeUserId;
            return (TInternalPropertiesDTO)this;
        }

        public TInternalPropertiesDTO SetInternalDataCreate(DateTime creationDate, long creationUserId)
        {
            CreationDate = creationDate;
            CreationUserId = creationUserId;
            return (TInternalPropertiesDTO)this;
        }

        public TInternalPropertiesDTO SetInternalDataChange(DateTime? changeDate, long? changeUserId)
        {
            ChangeDate = changeDate;
            ChangeUserId = changeUserId;
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

            LoggedUser loggedUser = SessionData.GetLoggedUser();
            if (loggedUser != null)
                CreationUserId = loggedUser.Id;

            return (TInternalPropertiesDTO)this;
        }

        public TInternalPropertiesDTO SetUpdateData()
        {
            ChangeDate = DateTime.Now;

            LoggedUser loggedUser = SessionData.GetLoggedUser();
            if (loggedUser != null)
                ChangeUserId = loggedUser.Id;

            return (TInternalPropertiesDTO)this;
        }
    }
}