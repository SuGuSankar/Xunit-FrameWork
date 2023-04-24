using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using Xunit.Abstractions;

namespace BDD_FrameWork
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper testHelper;
        public ChromeDriver driver;
        public UnitTest1(ITestOutputHelper itestHelper){
            this.testHelper = itestHelper;
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
             this.driver = new ChromeDriver();
        }

        [Fact]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            var title = driver.Title;
            Assert.Equal("google", title,true);
            testHelper.WriteLine(title);
            
        }

        [Fact]
        public void Test2()
        {
            testHelper.WriteLine("Failed Due to assertion");
            Assert.True(true);
            Console.WriteLine("xunit FrameWORK2");
            

        }
    }
}