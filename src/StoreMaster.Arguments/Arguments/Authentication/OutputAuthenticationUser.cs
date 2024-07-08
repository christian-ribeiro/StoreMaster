namespace StoreMaster.Arguments.Arguments
{
    public class OutputAuthenticationUser
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public OutputLanguage Language { get; set; }
        public OutputUserStatus UserStatus { get; set; }

        public OutputAuthenticationUser(long id, string code, string name, string email, string token, OutputLanguage language, OutputUserStatus userStatus)
        {
            Id = id;
            Code = code;
            Name = name;
            Email = email;
            Token = token;
            Language = language;
            UserStatus = userStatus;
        }
    }
}