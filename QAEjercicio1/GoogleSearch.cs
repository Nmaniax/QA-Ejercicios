using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace QAEjercicio1
{
    [TestClass]
    public class GoogleSearch
    {
        [TestMethod]
        public void Should_Search_Using_Firefox()
        {
            //initialize the Firefox Driver
            using (var driver = new FirefoxDriver())
            {
                //1. Maximize the browser
                driver.Manage().Window.Maximize();

                // 2. Go to the "Google" homepage
                driver.Navigate().GoToUrl("http://www.google.com");

                // 3. Find the search textbox by ID on the homepage
                var searchBox = driver.FindElementByName("q");

                // 4. Enter the text to search in the textbox
                searchBox.SendKeys("Automation using selenium 3.0 in C#");

                //5. Find the search button by Name on the homepage
                var searButton = driver.FindElementByXPath("/html/body/div/div/form/div/div/div/center/input[@name='btnK']");

                // 6. Click the "Submit()" to start the search
                searButton.Click();

                // 7. Find the "Id" of the div containing the results stats,
                // located just above the results table.
                var searchResults = driver.FindElementById("resultStats");
            }
        }

        [TestMethod]
        public void Should_Search_Using_Chrome()
        {
            //initialize the Firefox Driver
            using (var driver = new ChromeDriver())
            {
                //1. Maximize the browser
                driver.Manage().Window.Maximize();

                // 2. Go to the "Google" homepage
                driver.Navigate().GoToUrl("http://www.google.com");

                // 3. Find the search textbox by ID on the homepage
                var searchBox = driver.FindElementByName("q");

                // 4. Enter the text to search in the textbox
                searchBox.SendKeys("Automation using selenium 3.0 in C#");
                System.Threading.Thread.Sleep(2000);
                //5. Find the search button by Name on the homepage
                var searButton = driver.FindElementByXPath("/html/body/div/div/form/div/div/div/div/div/center/input[@class='gNO89b']");

                // 6. Click the "Submit()" to start the search
                searButton.Click();

                // 7. Find the "Id" of the div containing the results stats,
                // located just above the results table.
                var searchResults = driver.FindElementByXPath("/html/body/div/div/div/div/div/div/div/div[@id='resultStats']");
            }
        }

        [TestMethod]
        public void Should_Search_Using_IE()
        {
            //initialize the Firefox Driver
            using (var driver = new InternetExplorerDriver())
            {
                //1. Maximize the browser
                driver.Manage().Window.Maximize();

                // 2. Go to the "Google" homepage
                driver.Navigate().GoToUrl("http://www.google.com");

                // 3. Find the search textbox by ID on the homepage
                var searchBox = driver.FindElementByName("q");

                // 4. Enter the text to search in the textbox
                searchBox.SendKeys("Automation using selenium 3.0 in C#");
                System.Threading.Thread.Sleep(2000);

                //5. Find the search button by Name on the homepage
                var searButton = driver.FindElementByXPath("/html/body/div/div/form/div/div/div/div/div/center/input[@class='gNO89b']");

                // 6. Click the "Submit()" to start the search
                searButton.Click();

                // 7. Find the "Id" of the div containing the results stats,
                // located just above the results table.
                //var searchResults = driver.FindElementById("resultStats");
                System.Threading.Thread.Sleep(2000);
                var searchResults = driver.FindElementByXPath("/html/body/div/div/div/div/div/div/div/div[@id='resultStats']");
            }
        }

        [TestMethod]
        public void Should_Print_Elements()
        {
            //initialize the Firefox Driver
            using (var driver = new FirefoxDriver())
            {
                //1. Maximize the browser
                driver.Manage().Window.Maximize();

                // 2. Go to the "Google" homepage
                driver.Navigate().GoToUrl("http://www.google.com");

                // 3. Find the title and print
                var title = driver.Title.ToString();
                System.Diagnostics.Debug.WriteLine("Title: " + title);

                // 4. Find url and print
                var currentURL = driver.Url;
                System.Diagnostics.Debug.WriteLine("Current URL: " + currentURL);

                // 5. Print Source code
                var pageSource = driver.PageSource.ToString();
                System.Diagnostics.Debug.WriteLine("Page Source: " + pageSource);
            }
        }

        [TestMethod]
        public void Should_Print_Titles()
        {
            //initialize the Firefox Driver
            using (var driver = new ChromeDriver())
            {
                //1. Maximize the browser
                driver.Manage().Window.Maximize();

                // 2. Go to the "Google" homepage
                driver.Navigate().GoToUrl("http://www.google.com");

                // 3. Find the title and print
                var title = driver.Title.ToString();
                System.Diagnostics.Debug.WriteLine("Title: " + title);

                // 4. Go To "StackOverflow"
                driver.Navigate().GoToUrl("https://www.stackoverflow.com");

                // 5. Find the title and print
                title = driver.Title.ToString();
                System.Diagnostics.Debug.WriteLine("Title: " + title);

                // 6. Go to "Amazon"
                driver.Navigate().GoToUrl("https://www.amazon.com");

                // 7. Find the title and print
                title = driver.Title.ToString();
                System.Diagnostics.Debug.WriteLine("Title: " + title);

                // 8. Go back twice and show title
                driver.Navigate().Back();
                driver.Navigate().Back();
                title = driver.Title.ToString();
                System.Diagnostics.Debug.WriteLine("Back twice: " + title);

                // 9. Go foward and print
                driver.Navigate().Forward();
                title = driver.Title.ToString();
                System.Diagnostics.Debug.WriteLine("Foward: " + title);

                // 10. Refresh and print
                driver.Navigate().Refresh();
                title = driver.Title.ToString();
                System.Diagnostics.Debug.WriteLine("Refresh: " + title);

            }
        }

        [TestMethod]
        public void Should_Try_Login()
        {
            //initialize the Firefox Driver
            using (var driver = new ChromeDriver())
            {
                //1. Maximize the browser
                driver.Manage().Window.Maximize();

                // 2. Go to the "Mercado Libre" login homepage
                driver.Navigate().GoToUrl("https://www.mercadolibre.com/jms/mlm/lgz/msl/login/H4sIAAAAAAAEAzWOQQ6EIAxF79K10T3LuQjpYEEyMJBSgxPj3S0ms_y_r689IZUQv1Z-lcAAHTVFFwUmqAnFF842rjrISasWhf4xDwQZMwlxA3MOUaD1Rbo0VMI7KYO7bNan0rV6TmkXioZNpDazLL33ORM7XEuKb6bZlTznY1GOKcSmehofPL5rAo9NrDC6DxiPqdF1A3uSQ6HEAAAA/user");

                // 3. Find the user textbox and write
                var id = driver.FindElementById("user_id");
                id.SendKeys("tboanmaniax@hotmail.com");
                System.Threading.Thread.Sleep(2000);

                // 4. press loggin
                var logBtn = driver.FindElementByXPath("/html/body/main[@id='root-app']/div[@class='auth-email_nickname_view auth-container']/div[@id='wrap']/div[@id='main']/div[@class='ui-box--lite auth-box auth-box_container']/form[@id='login_user_form']/div[@class='ui-form__actions']/input[@class='ui-button ui-button--primary auth-button auth-button--user']");
                logBtn.Click();
                System.Threading.Thread.Sleep(3000);

                //5. Type password
                var passTxt = driver.FindElementById("password");
                passTxt.SendKeys("1234asd");
                System.Threading.Thread.Sleep(2000);

                // 6. Press login
                var loginBtn = driver.FindElementById("action-complete");
                loginBtn.Click();

                System.Threading.Thread.Sleep(5000);

            }
        }

        [TestMethod]
        public void Should_Try_Search_in_Amazon()
        {
            //initialize the Firefox Driver
            using (var driver = new ChromeDriver())
            {
                //1. Maximize the browser
                driver.Manage().Window.Maximize();

                // 2. Go to the "Mercado Libre" login homepage
                driver.Navigate().GoToUrl("http://www.amazon.com.mx");
                System.Threading.Thread.Sleep(10000);

                // 3. Find the user textbox and write
                var id = driver.FindElementById("twotabsearchtextbox");
                id.SendKeys("Selenium");
                System.Threading.Thread.Sleep(2000);

                // 4. press loggin
                var searchBtn = driver.FindElementByXPath("/html/body/div/header/div/div/div/div/form/div/div/input[@value='Ir']");
                searchBtn.Click();
                System.Threading.Thread.Sleep(2000);
                
                System.Threading.Thread.Sleep(10000);

            }
        }

    }
}
