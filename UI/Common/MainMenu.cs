using Framework;
using System;
using UI.Enums;

namespace UI.Common
{
    public class MainMenu
    {
        private const string SubmenuOptionXPathFormat = @"//li[contains(@class, 'open')]/ul/li[@class=""menu-item""][{0}]";

        private Element CompanyDropdown = ElementFactory
            .InitializeElement(@"//*[@class=""dropdown ss_menu_company_b""]/a");

        private Element CareerDropdown = ElementFactory
            .InitializeElement(@"//*[@class=""dropdown ss_menu_career_b""]/a");

        private Element PlusesDropdown = ElementFactory
            .InitializeElement(@"//*[@class=""dropdown ss_menu_pluses_b""]/a");

        private Element VacanciesDropdown = ElementFactory
            .InitializeElement(@"//*[@class=""dropdown ss_menu_vacansys_b""]/a");

        private Element UniverDropdown = ElementFactory
            .InitializeElement(@"//*[@class=""dropdown ss_menu_univer_b""]/a");

        private Element PressDropdown = ElementFactory
            .InitializeElement(@"//*[@class=""dropdown ss_menu_press_b""]/a");

        private Element ContactsButton = ElementFactory
            .InitializeElement(@"//*[@class=""dropdown ss_menu_contacts_b""]/a");

        private Element SubmenuOption;

        public void NavigateViaMenu(MainMenuOptions mainMenuOption, int submenuOptionNumber = 0)
        {
            switch (mainMenuOption)
            {
                case MainMenuOptions.Company:
                    CompanyDropdown.Click();
                    SelectSubmenuOption(submenuOptionNumber);
                    break;
                case MainMenuOptions.Career:
                    CareerDropdown.Click();
                    SelectSubmenuOption(submenuOptionNumber);
                    break;
                case MainMenuOptions.Pluses:
                    PlusesDropdown.Click();
                    SelectSubmenuOption(submenuOptionNumber);
                    break;
                case MainMenuOptions.Vacancies:
                    VacanciesDropdown.Click();
                    SelectSubmenuOption(submenuOptionNumber);
                    break;
                case MainMenuOptions.Univer:
                    UniverDropdown.Click();
                    SelectSubmenuOption(submenuOptionNumber);
                    break;
                case MainMenuOptions.Press:
                    PressDropdown.Click();
                    SelectSubmenuOption(submenuOptionNumber);
                    break;
                case MainMenuOptions.Contacts:
                    ContactsButton.Click();
                    break;
                default:
                    break;
            }
        }

        private void SelectSubmenuOption(int optionNumber)
        {
            SubmenuOption = ElementFactory.InitializeElement(String.
                Format(SubmenuOptionXPathFormat, optionNumber));
            SubmenuOption.Click();
        }
    }
}
