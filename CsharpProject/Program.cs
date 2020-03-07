using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace CsharpProject
{
    class Program
    {
        
       public  static void Main(string[] args)
        {
            IWebDriver driver;
            Console.WriteLine("welcome to lic program");
        
        
            //load chromedriver 
            driver = new ChromeDriver();

           // access url
            driver.Navigate().GoToUrl("https://licindia.in/");
        //}

        //[Test]
      //  public void ExecuteTest()
        //{

            //maximize window
            driver.Manage().Window.Maximize();

            //click on customer portal
            SetterGetterMethods.Clickelement(driver, "//*[@id='mid']/div[1]/div[1]/h2/a[3]", "XPath");

            // handle alert
            driver.SwitchTo().Alert().Accept();
            System.Threading.Thread.Sleep(5000);

            //click on new user button
            SetterGetterMethods.Clickelement(driver, "//*[@id='container']/article/p[2]/input[1]", "XPath");
            System.Threading.Thread.Sleep(5000);

            //enter value in policy textbox
            SetterGetterMethods.SendkeysMethod(driver, "da_textfield-1143-inputEl", "Id", "123456789");

            //enter value in installment premium without tax 
            SetterGetterMethods.SendkeysMethod(driver, "DScurrencyfield-1151-inputEl", "Id", "100000");
        }

       // [Test]
        //public void Cleanup()
        //{
          //  driver.Close();
        //}
    }
}
