namespace StoreMaster.Arguments.Arguments
{
    public class OutputAuthentication
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public OutputLanguage Language { get; set; }
        public OutputUserStatus UserStatus { get; set; }

        public OutputAuthentication(long id, string code, string name, string email, string token, string refreshToken, OutputLanguage language, OutputUserStatus userStatus)
        {
            Id = id;
            Code = code;
            Name = name;
            Email = email;
            Token = token;
            RefreshToken = refreshToken;
            Language = language;
            UserStatus = userStatus;
        }
    }
}