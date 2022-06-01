using OpenQA.Selenium;

namespace AuthMantisPageTests.PageObjects
{
    class ViewWithAuthorizedPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _reportIssue = By.XPath("//a[@class='btn btn-primary btn-sm']");

        public ViewWithAuthorizedPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public MyViewPageObject GetIssue()
        {
            _webDriver.FindElement(_reportIssue).Click();

            return new MyViewPageObject(_webDriver);
        }
    }
}
