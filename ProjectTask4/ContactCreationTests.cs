using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace ProjectTask4
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {
        [Test]
        public void ContactCreationTest()
        {
            OpenMainPage();
            Login(new AccountData("admin", "secret"));
            AddNewContact();
            ContactData contact = new ContactData("Test111");
            contact.Middlename = "Test222";
            contact.Lastname = "Test333";
            FillContactForm(contact);
            SubmitContactCreation();
            ReturnToMainPage();
            Logout();
        }
    }
}
