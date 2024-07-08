namespace StoreMaster.Arguments.Arguments
{
    public class InputRefreshTokenAuthentication
    {
        public string Token { get; private set; }
        public string RefreshToken { get; private set; }

        public InputRefreshTokenAuthentication(string token, string refreshToken)
        {
            Token = token;
            RefreshToken = refreshToken;
        }
    }
}