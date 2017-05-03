using Framework;
using System;

namespace UI.Pages
{
    public abstract class BasePage
    {
        public MainMenu MainMenu = new MainMenu();

        public String Url { get; protected set; }

        public void OpenPage()
        {
            DriverManager.OpenUrl(Url);
        }
    }
}
