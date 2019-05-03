using AuBicpBot.Enums;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace AuBicpBot
{
    public class WebDriverFactory 
    {
        public static IWebDriver CriarWebDriver(EBrowser browser, string caminhoDriver, bool headless)
            {
                IWebDriver webDriver = null;

                switch(browser)
                {
                    case EBrowser.Chrome:
                    //driver = new ChromeDriver(caminhoDriver, opcoes);
                    ChromeOptions opcoes = new ChromeOptions();
                    if(headless)
                        opcoes.AddArgument("--headless");
                        
                        webDriver = new ChromeDriver(caminhoDriver, opcoes);

                    break;

                    case EBrowser.Firefox:
                    FirefoxOptions opcoesFF = new FirefoxOptions();
                    if (headless)
                        opcoesFF.AddArgument("--headless");
                    
                    webDriver = new FirefoxDriver(caminhoDriver, opcoesFF);

                    break;
                }                

               return webDriver; 
            }
    }
}