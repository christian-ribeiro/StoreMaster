namespace StoreMaster.Arguments
{
    public class InputRegisterAuthenticationUser
    {
        public string Code { get; private set; }
        public string Name { get; private set; }
        public string Password { get; private set; }
        public string ConfirmPassword { get; private set; }
        public string Email { get; private set; }
        public long LanguageId { get; private set; }

        public InputRegisterAuthenticationUser(string code, string name, string password, string confirmPassword, string email, long languageId)
        {
            Code = code;
            Name = name;
            Password = password;
            ConfirmPassword = confirmPassword;
            Email = email;
            LanguageId = languageId;
        }
    }
}