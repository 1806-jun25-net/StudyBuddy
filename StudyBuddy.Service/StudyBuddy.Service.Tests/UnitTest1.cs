using StudyBuddy.Service.API.Controllers;
using System;
using Xunit;

namespace StudyBuddy.Service.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var controller = new ValuesController();

            var result = controller.Get();

            Assert.NotNull(result);
        }
    }
}
