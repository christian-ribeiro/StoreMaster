namespace StoreMaster.Arguments.Arguments
{
    public class OutputAuthentication
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }

        public OutputUser OutputUser { get; set; }

        public OutputAuthentication(string token, string refreshToken, OutputUser outputUser)
        {
            Token = token;
            RefreshToken = refreshToken;
            OutputUser = outputUser;
        }
    }
}