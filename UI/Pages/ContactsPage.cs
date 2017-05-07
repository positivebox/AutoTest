using Framework;

namespace UI.Pages
{
    public class ContactsPage : BasePage
    {
        private Element NameField = ElementFactory
            .InitializeElement(@"//*[@name=""name""]");
        private Element EmailField = ElementFactory
            .InitializeElement(@"//*[@name=""email""]");
        private Element MessageField = ElementFactory
            .InitializeElement(@"//*[@name=""message""]");
        private Element SubmitButton = ElementFactory
            .InitializeElement(@"//*[@class=""btn-submit ss_contact_feedback_submit""]");

        internal ContactsPage()
        {
            Url = "https://softserve.ua/ua/contacts/";
        }

        public void FillAndSubmitFeedBack(string name, string email, string message)
        {
            NameField.SendKeys(name);
            EmailField.SendKeys(email);
            MessageField.SendKeys(message);
            SubmitButton.Click();
        }
    }
}
