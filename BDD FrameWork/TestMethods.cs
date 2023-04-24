using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace BDD_FrameWork
{
    public class TestMethods:IClassFixture<BaseClass>
    {
        private readonly ITestOutputHelper testHelper;
        private readonly BaseClass fixture;

        public TestMethods(BaseClass driverFixture,ITestOutputHelper test) 
        {
            this.testHelper = test;
            this.fixture = driverFixture;
        }

        [Fact]
        public void Test1()
        {
            var driver = fixture.chromedriver;
            driver.
                Navigate().
                GoToUrl("https://www.google.com/");
            testHelper.WriteLine(driver.Title);
           
        }

        [Theory]
        [InlineData("Sugumar")]
        [InlineData("mar")]
        [InlineData("s")]
        [InlineData("sugu")]
        public void Test2(String searchContent) 
        {
            var driver = fixture.chromedriver;
            driver.
                Navigate().
                GoToUrl("https://www.google.com/");
            driver.FindElement(By.Id("APjFqb")).SendKeys(searchContent);
        }




    }
}
