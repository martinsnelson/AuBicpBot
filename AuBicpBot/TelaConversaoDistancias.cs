using System;
using AuBicpBot.Enums;
//using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
//using Selenium.Utils;

namespace ConversorDistancias.Testes
{
    public class TelaConversaoDistancias
    {
        // private IConfiguration _configuration;
        // private EBrowser _browser;
        // private IWebDriver _driver;

        // public TelaConversaoDistancias(IConfiguration configuration, EBrowser browser)
        // {
        //     _configuration = configuration;
        //     _browser = browser;

        //     string caminhoDriver = null;
        //     if (browser == EBrowser.Firefox)
        //     {
        //         caminhoDriver = _configuration.GetSection("Selenium:CaminhoDriverFirefox").Value;
        //     }
        //     else if (browser == EBrowser.Chrome)
        //     {
        //         caminhoDriver = _configuration.GetSection("Selenium:CaminhoDriverChrome").Value;
        //     }

        //     _driver = WebDriverFactory.CreateWebDriver(
        //         browser, caminhoDriver, true);
        // }
        // public void CarregarPagina()
        // {
        //     _driver.LoadPage(TimeSpan.FromSeconds(5), _configuration.GetSection("Selenium:UrlTelaConversaoDistancias").Value);
        // }

        // public void PreencherDistanciaMilhas(double valor)
        // {
        //     _driver.SetText(
        //         By.Name("DistanciaMilhas"),
        //         valor.ToString());
        // }

        // public void ProcessarConversao()
        // {
        //     _driver.Submit(By.Id("btnConverter"));

        //     WebDriverWait wait = new WebDriverWait(
        //         _driver, TimeSpan.FromSeconds(10));
        //     wait.Until((d) => d.FindElement(By.Id("DistanciaKm")) != null);
        // }

        // public double ObterDistanciaKm()
        // {
        //     return Convert.ToDouble(
        //         _driver.GetText(By.Id("DistanciaKm")));
        // }

        // public void Fechar()
        // {
        //     _driver.Quit();
        //     _driver = null;
        // }
    }
}