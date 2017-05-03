using Framework;
using System;
using UI.Enums;

namespace UI
{
    public class MainMenu
    {
        private const string SubmenuOptionXPathFormat = @"//li[contains(@class, 'open')]/ul/li[@class=""menu-item""][{0}]";

        private Element CompanyDropdown { get { return CompanyDropdown
                    .ElementFactory(@"//*[@class=""dropdown ss_menu_company_b""]/a"); } }
        private Element CareerDropdown { get { return CareerDropdown
                    .ElementFactory(@"//*[@class=""dropdown ss_menu_career_b""]/a"); } }
        private Element PlusesDropdown { get { return PlusesDropdown
                    .ElementFactory(@"//*[@class=""dropdown ss_menu_pluses_b""]/a"); } }
        private Element VacanciesDropdown { get { return VacanciesDropdown
                    .ElementFactory(@"//*[@class=""dropdown ss_menu_vacansys_b""]/a"); } }
        private Element UniverDropdown { get { return UniverDropdown
                    .ElementFactory(@"//*[@class=""dropdown ss_menu_univer_b""]/a"); } }
        private Element PressDropdown { get { return PressDropdown
                    .ElementFactory(@"//*[@class=""dropdown ss_menu_press_b""]/a"); } }
        private Element ContactsButton { get { return ContactsButton
                    .ElementFactory(@"//*[@class=""dropdown ss_menu_contacts_b""]/a"); } }
        private Element SubmenuOption { get; }

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
            SubmenuOption.ElementFactory(String.Format(SubmenuOptionXPathFormat, optionNumber));
            SubmenuOption.Click();
        }
    }
}
