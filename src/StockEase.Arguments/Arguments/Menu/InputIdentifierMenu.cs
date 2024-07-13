using StockEase.Arguments.Arguments.Base;

namespace StockEase.Arguments.Arguments
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