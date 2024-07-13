namespace StockEase.Arguments
{
    public class LoggedUser
    {
        public long Id { get; private set; }
        public string Code { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public long LanguageId { get; private set; }
        public long UserStatusId { get; private set; }

        public LoggedUser(long id, string code, string name, string email, long languageId, long userStatusId)
        {
            Id = id;
            Code = code;
            Name = name;
            Email = email;
            LanguageId = languageId;
            UserStatusId = userStatusId;
        }
    }
}