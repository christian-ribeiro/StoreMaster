using StoreMaster.Arguments.Arguments.Base;

namespace StoreMaster.Arguments.Arguments
{
    public class InputUpdateUser : BaseInputUpdate<InputUpdateUser>
    {
        public string Code { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public long LanguageId { get; private set; }
        public long UserStatusId { get; private set; }

        public InputUpdateUser(string code, string name, string email, long languageId, long userStatusId)
        {
            Code = code;
            Name = name;
            Email = email;
            LanguageId = languageId;
            UserStatusId = userStatusId;
        }
    }
}