namespace StoreMaster.Arguments.Arguments
{
    public class InputAuthentication
    {
        public string Email { get; private set; }
        public string Password { get; private set; }

        public InputAuthentication(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}