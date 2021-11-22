using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationFb
{
    class Program
    {
        static void Main(string[] args)
        {
            
               WebDriver driver = new ChromeDriver();
            

          
            
                driver.Url = "https://opensource-demo.orangehrmlive.com/";
                driver.Navigate();
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                driver.FindElement(By.Id("txtUsername")).SendKeys("Admin");
                driver.FindElement(By.Id("txtPassword")).SendKeys("admin123");
                driver.FindElement(By.Id("btnLogin")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//b[contains(text(),'Admin')]")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("btnAdd")).Click();
                Thread.Sleep(2000);
                SelectElement role = new SelectElement(driver.FindElement(By.Id("systemUser_userType")));
                role.SelectByText("Admin");
                driver.FindElement(By.Id("systemUser_employeeName_empName")).SendKeys("praveen");
                driver.FindElement(By.Id("systemUser_userName")).SendKeys("Praveen");
                SelectElement status = new SelectElement(driver.FindElement(By.Id("systemUser_status")));
                status.SelectByText("Enabled");
                driver.FindElement(By.Id("systemUser_password")).SendKeys("Praveen@skdwwu");
                driver.FindElement(By.Id("systemUser_confirmPassword")).SendKeys("Praveen@skdwwu");
                Thread.Sleep(2000);
                driver.FindElement(By.Id("btnSave")).Click();
            }

        }
    }
    
