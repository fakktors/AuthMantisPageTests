using OpenQA.Selenium;

namespace AuthMantisPageTests.PageObjects
{
    class BugReportPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _categoryIssue = By.XPath("//option[@value='3']");
        private readonly By _summaryIssue = By.XPath("//input[@id='summary']");
        private readonly By _descriptionIssue = By.XPath("//textarea[@id='description']");
        private readonly By _submitButton = By.XPath("//input[@type='submit']");

        public BugReportPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public ViewWithAuthorizedPageObject CreateIssue(string sendSummary, string sendDescription)
        {
            _webDriver.FindElement(_submitButton).Click();
            _webDriver.FindElement(_categoryIssue).Click();
            _webDriver.FindElement(_summaryIssue).SendKeys(sendSummary);
            _webDriver.FindElement(_descriptionIssue).SendKeys(sendDescription);

            return new ViewWithAuthorizedPageObject(_webDriver);
        }
    }
}
