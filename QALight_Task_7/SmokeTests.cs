using NUnit.Framework;
using NUnit.Framework.Legacy;
using QALight_Task_7;


namespace Tests
{
    [TestFixture]
    public class SmokeTests : TestBase
    {
        string _userName = "standard_user";
        string _password = "secret_sauce";

        LoginPage loginPage = new LoginPage(_driver);

        [Test, Order(1)]
        public void LoginIn()
        {

            loginPage.Login(_userName, _password);
        }

        [Test, Order(2)]
        public void FindItemPrice()
        {
            var mainPage = loginPage.Login(_userName, _password);

            var test = mainPage.ItemPrice_Field1.Text;

            ClassicAssert.AreEqual("$29.99", test);
        }

        [Test, Order(3)]
        public void AddItemToTheCart()
        {
            var mainPage = loginPage.Login(_userName, _password);
            /*
            mainPage.AddToCart_Btn.Click();

            var test = loginPage.ShoppingCart_Bdg.Text;

            var itemsCount = mainPage.ShoppingCart_Bdg.Text;

            ClassicAssert.AreEqual("29.99", itemsCount);*/
        }
    }
}