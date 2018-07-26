using StudyBuddy.MVCFrontend.Controllers;
using System;
using Xunit;

namespace StudyBuddy.MVCTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var controller = new HomeController();

            var result = controller.Index();

            Assert.NotNull(result);
        }
    }
}
