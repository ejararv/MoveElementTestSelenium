using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace MoveElementTestSelenium
{

    public class Tests
    {
        IWebDriver driver = new ChromeDriver();
    
        private By _sourceImg = By.XPath("//*[@id='gallery']/li[1]/h5");
        private By _targetImg = By.XPath("//*[@id='trash']");
        private By _trashImg = By.XPath("/html/body/div[1]/div/ul/li/img");
        private By _galery = By.XPath("//*[@id=gallery']");
        private By _frameArea2 = By.XPath("//*[@id='post - 2669']/div[2]/div/div/div[3]/p/iframe");
        private By _dragSource = By.XPath("//*[@id='draggable']");
        private By _dragtarget1 = By.XPath("//*[@id='droppable']/p");
        private By _dragtarget2 = By.XPath("//*[@id='droppable - inner']/p");
        private By _dragtarget3 = By.XPath("//*[@id='droppable2']/p");
        private By _dragtarget4 = By.XPath("//*[@id='droppable2 - inner']/p");
        private By _propagationButton = By.XPath("//*[@id='Propagation']");

        [SetUp]
        public void Setup()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.globalsqa.com/demo-site/draganddrop");
        }

        [Test]
        public void DeletIconTest()
        {
            IWebDriver driver = new ChromeDriver();
            IWebElement frameArea = driver.FindElement(_frameArea);
            driver.SwitchTo().Frame(frameArea);

            IWebElement deleteButton = driver.FindElement(_deleteButton);
          
            Thread.Sleep(1000);
            deleteButton.Click();
            Thread.Sleep(1000);

        }

 

        [Test]
        public void DragAndDropTest()
        {
            IWebDriver driver = new ChromeDriver();
            IWebElement frameArea = driver.FindElement(_frameArea);
            driver.SwitchTo().Frame(frameArea);


            IWebElement source = driver.FindElement(_sourceImg);
            IWebElement target = driver.FindElement(_targetImg);

            Actions actions = new Actions(driver);


            actions.DragAndDrop(source, target).Build().Perform();
            Thread.Sleep(1000);
        }

        [TearDown]
        public void Teardown()
        {
            
        }
    }
}