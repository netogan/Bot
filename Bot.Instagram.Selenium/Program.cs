using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using Microsoft.Extensions.Configuration;
using System.Text.RegularExpressions;
using System.Threading;

namespace Bot.Instagram.Selenium
{
    public class Program
    {
        static void Main(string[] args)
        {
            var regexRaiz = new Regex(@"(?<!fil)[A-Za-z]:\\+[\S\s]*?(?=\\+bin)");

            var diretorioRaiz = regexRaiz.Match(AppDomain.CurrentDomain.BaseDirectory).Value;

            var builder = new ConfigurationBuilder().SetBasePath(diretorioRaiz).AddJsonFile("appsettings.json");

            var configuration = builder.Build();

            IWebDriver driver = new ChromeDriver($"{diretorioRaiz}\\WebDriver");

            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

                driver.Navigate().GoToUrl("https://www.instagram.com/accounts/login/");

                var usuario = configuration["instagram:usuario"];
                var senha = configuration["instagram:senha"];

                wait.Until(ExpectedConditions.ElementExists(By.Name("username"))).SendKeys(usuario);
                wait.Until(ExpectedConditions.ElementExists(By.Name("password"))).SendKeys(senha);
                wait.Until(ExpectedConditions.ElementExists(By.CssSelector("button[type='submit']"))).Click();

                Thread.Sleep(TimeSpan.FromSeconds(5));

                driver.Navigate().GoToUrl("https://www.instagram.com/netogan/");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                driver.Close();
                driver.Dispose();
            }

            Console.ReadKey();
        }
    }
}
