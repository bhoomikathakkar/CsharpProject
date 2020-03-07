using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpProject
{
    class SetterGetterMethods
    {
        //Click element method
        public static String Clickelement(IWebDriver driver,String element,String elementType)
        {
            if (elementType == "Id")
            {
                driver.FindElement(By.Id(element)).Click();
            }
            if (elementType == "Name")
            {
                driver.FindElement(By.Name(element)).Click();
            }
            if (elementType == "XPath")
            {
                driver.FindElement(By.XPath(element)).Click();
            }
            
                return string.Empty;
        }
        //Sendkeys method
        public  static String SendkeysMethod(IWebDriver driver, String element, String elementType,String value)
        {
            if (elementType == "Id")
            {
                driver.FindElement(By.Id(element)).SendKeys(value);
            }
            if (elementType == "Name")
            {
                driver.FindElement(By.Name(element)).SendKeys(value);
            }
            if (elementType == "XPath")
            {
                driver.FindElement(By.XPath(element)).SendKeys(value);
            }
           
                return string.Empty;
        }
    }
}
