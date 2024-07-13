using StockEase.Arguments.Arguments.Base;

namespace StockEase.Arguments.Arguments
{
    public class InputCreateUser : BaseInputCreate<InputCreateUser>
    {
        public string Code { get; private set; }
        public string Name { get; private set; }
        public string Password { get; private set; }
        public string ConfirmPassword { get; private set; }
        public string Email { get; private set; }
        public long LanguageId { get; private set; }
        public long UserStatusId { get; private set; }

        public InputCreateUser(string code, string name, string password, string confirmPassword, string email, long languageId, long userStatusId)
        {
            Code = code;
            Name = name;
            Password = password;
            ConfirmPassword = confirmPassword;
            Email = email;
            LanguageId = languageId;
            UserStatusId = userStatusId;
        }
    }
}