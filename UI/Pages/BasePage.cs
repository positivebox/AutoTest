using Framework;
using UI.Common;

namespace UI.Pages
{
    public abstract class BasePage
    {
        public MainMenu MainMenu = new MainMenu();

        public string Url { get; protected set; }

        public void OpenPage()
        {
            DriverManager.OpenUrl(Url);
        }
    }
}
