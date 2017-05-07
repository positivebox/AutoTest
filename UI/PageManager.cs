using UI.Pages;

namespace UI
{
    public static class PageManager
    {
        public static HomePage HomePage => new HomePage();
        public static ContactsPage ContactsPage => new ContactsPage();
        public static BenefitsPage BenefitsPage => new BenefitsPage();
    }
}
