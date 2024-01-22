using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace QALight_Task_7
{

    public class MainPage
    {
        private ChromeDriver _driver;


        public MainPage(ChromeDriver driver)
        {
            _driver = driver;
        }

        //Find first element with 29.99 price using Xpath

        public IWebElement ItemPrice_Field1 => _driver.FindElement(By.XPath("//div[@class='inventory_item_price'and text()='29.99']"));
        //*/public IWebElement ItemPrice_Field1 => _driver.FindElement(By.XPath("//div[@class='inventory_item_price'and text()='29.99']/text()[2]"));*/
        ////div[contains(text(),'29.99')] - cannot find needed price using this exprassion
        //public IWebElement ItemPrice_Field2 => _driver.FindElement(By.XPath("//*[contains(@class,'inventory_item_price') and text()='29.99']/text()[2]"));
        //public IWebElement ItemPrice_Field3 => _driver.FindElement(By.XPath("//*[text()='29.99']/text()[2]"));
        //public IWebElement ItemPrice_Field4 => _driver.FindElement(By.XPath("//*[@id='inventory_container']/div/div[1]/div[2]/div[2]/div/text()[2]"));
        //public IWebElement ItemPrice_Field5 => _driver.FindElement(By.XPath("//div[@class='inventory_item_price'and text()='29.99']|//div[@class='inventory_item_price'and text()='29.99']/text()[2]"));
        //public IWebElement ItemPrice_Field6 => _driver.FindElement(By.XPath("//*[starts-with(@class,'inventory_item_price')and text()='29.99']/text()[2]"));
        //public IWebElement ItemPrice_Field7 => _driver.FindElement(By.XPath("//div[contains(@class,'inventory_item_price')][contains(string(),'29.99')]/text()[2]"));
        //public IWebElement ItemPrice_Field8 => _driver.FindElement(By.XPath("(//div/descendant::div[1]/text()[2])[1]"));
        //public IWebElement ItemPrice_Field9 => _driver.FindElement(By.XPath("(//div/self::*/text()[2])[1]"));
        //public IWebElement ItemPrice_Field10 => _driver.FindElement(By.XPath("(//child::div/text()[2])[1]"));
        //public IWebElement ItemPrice_Field11 => _driver.FindElement(By.XPath("(//div/ancestor::*)[23]/div/text()[2]"));
        //public IWebElement ItemPrice_Field12 => _driver.FindElement(By.XPath("(//div/parent::*)[22]/div/text()[2]"));
        //public IWebElement ItemPrice_Field13 => _driver.FindElement(By.XPath("(//div/following::*)[40]/text()[2]"));
        //public IWebElement ItemPrice_Field14 => _driver.FindElement(By.XPath("(//div/preceding::*)[64]/text()[2]"));
        //public IWebElement ItemPrice_Field15 => _driver.FindElement(By.XPath("(//div/following-sibling::*)[8]/div/text()[2]"));
        //public IWebElement ItemPrice_Field16 => _driver.FindElement(By.XPath("(//div/preceding-sibling::*)[9]/div[2]//text()[2]"));
        //public IWebElement ItemPrice_Field17 => _driver.FindElement(By.XPath("(//div/descendant-or-self::*)[51]/text()[2]"));
        //public IWebElement ItemPrice_Field18 => _driver.FindElement(By.XPath("(//div/ancestor-or-self::*)[32]/div/text()[2]"));

        //Find first element with 29.99 price using CSS selectors
        public IWebElement ItemPrice_Field19 => _driver.FindElement(By.CssSelector("div[class='inventory_item_price']"));
        public IWebElement ItemPrice_Field20 => _driver.FindElement(By.CssSelector("div.inventory_item_price"));
        public IWebElement ItemPrice_Field21 => _driver.FindElement(By.CssSelector("[class^='inventory_item_price']"));
        public IWebElement ItemPrice_Field22 => _driver.FindElement(By.CssSelector("[class*='inventory_item_price']"));
        public IWebElement ItemPrice_Field23 => _driver.FindElement(By.CssSelector(".pricebar div"));
        public IWebElement ItemPrice_Field24 => _driver.FindElement(By.CssSelector("div[class='inventory_item_price']:nth-child(1)"));
        public IWebElement ItemPrice_Field25 => _driver.FindElement(By.CssSelector("div[class='inventory_item_price']:nth-of-type(1)"));

    }
}
