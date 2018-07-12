using Microsoft.VisualStudio.TestTools.UnitTesting;
using continuousweb2.Controllers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc.Abstractions;

namespace continuousweb2.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var homeController = new HomeController();
            var result = homeController.About();
        }
    }
}
