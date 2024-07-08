namespace StoreMaster.Arguments.Arguments
{
    public class InputAuthenticationUser
    {
        public string Email { get; private set; }
        public string Password { get; private set; }

        public InputAuthenticationUser(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}