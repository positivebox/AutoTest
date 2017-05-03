using Framework;

namespace UI.Pages
{
    public class ContactsPage : BasePage
    {
        private Element NameField { get { return NameField
                    .ElementFactory(@"//*[@name=""name""]"); } }
        private Element EmailField { get { return EmailField
                    .ElementFactory(@"//*[@name=""email""]"); } }
        private Element MessageField { get { return MessageField
                    .ElementFactory(@"//*[@name=""message""]"); } }
        private Element SubmitButton { get { return SubmitButton
                    .ElementFactory(@"//*[@class=""btn-submit ss_contact_feedback_submit""]"); } }

        public ContactsPage()
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
