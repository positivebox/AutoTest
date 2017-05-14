using UI.Pages;
using UI.Pages.Benefits;
using UI.Pages.Vacancies;

namespace UI
{
    public static class PageManager
    {
        public static HomePage HomePage => new HomePage();

        public static OpenVacanciesPage OpenVacanciesPage => new OpenVacanciesPage();
        public static VacancyPage VacancyPage => new VacancyPage();

        public static BenefitsPage BenefitsPage => new BenefitsPage();

        public static ContactsPage ContactsPage => new ContactsPage();
    }
}
