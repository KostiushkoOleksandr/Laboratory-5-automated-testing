using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;

namespace GameDev
{
    public class Tests
    {
        //Браузер драйвер
        IWebDriver webDriver = new ChromeDriver("D:");

        [SetUp]
        public void Setup()
        {
            //Навігація по сайту
            webDriver.Navigate().GoToUrl("https://gamedev.dou.ua/");

            //webDriver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {

            //1) Перевірка переходу на новину відкриття офісу...............................................

            IWebElement lnkOpenOffice = webDriver.FindElement(By.LinkText("Відкриття офісу в Польщі — досвід і поради від Room 8 Group"));

            lnkOpenOffice.Click();

            //2) тестування авторизація на сайті...............................................

            IWebElement lnkLogin = webDriver.FindElement(By.LinkText("Вхід та реєстрація"));

            lnkLogin.Click();

            //3) тестування пошук на сайті....................................................

            IWebElement element = webDriver.FindElement(By.Id("txtGlobalSearch"));

            element.SendKeys("react" + Keys.Enter);

            IList<IWebElement> list = webDriver.FindElements(By.XPath(".//*[@class='menu-site menu-site__gamedev']"));

            Assert.Pass();

            //4) тестування перехіду по хедеру на сайті....................................................

            IWebElement lnkNews = webDriver.FindElement(By.LinkText("Новини"));

            lnkNews.Click();

            IWebElement lnkArticles = webDriver.FindElement(By.LinkText("Статті"));

            lnkArticles.Click();

            IWebElement lnkBlogs = webDriver.FindElement(By.LinkText("Блоги"));

            lnkBlogs.Click();

            IWebElement lnkForum = webDriver.FindElement(By.LinkText("Форум"));

            lnkForum.Click();

            IWebElement lnkVacancies = webDriver.FindElement(By.LinkText("Вакансії"));

            lnkVacancies.Click();


            //5) Змінюємо інтерфейс сайту на англійську мову...................................................

            IWebElement lnkClick = webDriver.FindElement(By.LinkText("English"));

            lnkClick.Click();

            //6) Відкриття модального вікна підтримки..................................................

            IWebElement lnkSupport = webDriver.FindElement(By.LinkText("support@dou.ua"));

            lnkSupport.Click();

            //6) Перехід на профіль користувача..................................................

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