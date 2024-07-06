using StoreMaster.Arguments.Arguments.Base;

namespace StoreMaster.Arguments.Arguments
{
    public class InputUpdateUser : BaseInputUpdate<InputUpdateUser>
    {
        public string Email { get; private set; }
        public string Name { get; private set; }

        public InputUpdateUser(string email, string name)
        {
            Email = email;
            Name = name;
        }
    }
}