using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace QALight_Task_7
{
    public class LoginPage
    {
        ChromeDriver _driver;

        public LoginPage(ChromeDriver dirver)
        {
            _driver = dirver;
        }

        public IWebElement UserName_Field => _driver.FindElement(By.Id("user-name"));
        public IWebElement Password_Field => _driver.FindElement(By.Id("password"));
        public IWebElement LogIn_Btn => _driver.FindElement(By.Id("login-button"));
        public IWebElement ShoppingCart_Bdg => _driver.FindElement(By.ClassName("shopping_cart_badge"));



        public MainPage Login(string userName, string password)
        {
            UserName_Field.SendKeys(userName);
            Password_Field.SendKeys(password);
            LogIn_Btn.Click();

            return new MainPage(_driver);
        }
    }
}