using StoreMaster.Arguments.Arguments.Base;

namespace StoreMaster.Arguments.Arguments
{
    public class InputIdentifierMenu : BaseInputIdentifier<InputIdentifierMenu>
    {
        public string Path { get; private set; }

        public InputIdentifierMenu() { }

        public InputIdentifierMenu(string path)
        {
            Path = path;
        }
    }
}