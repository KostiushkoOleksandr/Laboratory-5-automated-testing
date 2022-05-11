using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;

namespace GameDev
{
    public class Tests
    {
        //������� �������
        IWebDriver webDriver = new ChromeDriver("D:");

        [SetUp]
        public void Setup()
        {
            //�������� �� �����
            webDriver.Navigate().GoToUrl("https://gamedev.dou.ua/");

            //webDriver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {

            //1) �������� �������� �� ������ �������� �����...............................................

            IWebElement lnkOpenOffice = webDriver.FindElement(By.LinkText("³������� ����� � ������ � ����� � ������ �� Room 8 Group"));

            lnkOpenOffice.Click();

            //2) ���������� ����������� �� ����...............................................

            IWebElement lnkLogin = webDriver.FindElement(By.LinkText("���� �� ���������"));

            lnkLogin.Click();

            //3) ���������� ����� �� ����....................................................

            IWebElement element = webDriver.FindElement(By.Id("txtGlobalSearch"));

            element.SendKeys("react" + Keys.Enter);

            IList<IWebElement> list = webDriver.FindElements(By.XPath(".//*[@class='menu-site menu-site__gamedev']"));

            Assert.Pass();

            //4) ���������� �������� �� ������ �� ����....................................................

            IWebElement lnkNews = webDriver.FindElement(By.LinkText("������"));

            lnkNews.Click();

            IWebElement lnkArticles = webDriver.FindElement(By.LinkText("�����"));

            lnkArticles.Click();

            IWebElement lnkBlogs = webDriver.FindElement(By.LinkText("�����"));

            lnkBlogs.Click();

            IWebElement lnkForum = webDriver.FindElement(By.LinkText("�����"));

            lnkForum.Click();

            IWebElement lnkVacancies = webDriver.FindElement(By.LinkText("������"));

            lnkVacancies.Click();


            //5) ������� ��������� ����� �� ��������� ����...................................................

            IWebElement lnkClick = webDriver.FindElement(By.LinkText("English"));

            lnkClick.Click();

            //6) ³������� ���������� ���� ��������..................................................

            IWebElement lnkSupport = webDriver.FindElement(By.LinkText("support@dou.ua"));

            lnkSupport.Click();

            //6) ������� �� ������� �����������..................................................

            IWebElement lnkUser = webDriver.FindElement(By.LinkText("Andrew Labunsky"));

            lnkUser.Click();
        }

        [TearDown]
        public void TearDown()
        {
            
            webDriver.Quit();
        }
    }
}