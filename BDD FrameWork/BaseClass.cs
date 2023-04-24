using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using Xunit.Abstractions;

namespace BDD_FrameWork
{
    public  class BaseClass : IDisposable
    {

        public ChromeDriver chromedriver { get; private set; }

        public BaseClass()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            chromedriver = new ChromeDriver();
        }

        

        public void Dispose()
        {
            chromedriver.Quit();
            chromedriver.Dispose();
            
        }

    }
}
