using System;
using Week8Demo.Controllers;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void GetRetunsString()
        {
            //Arrange
            var controller = new TasksController();


            //Act
            var result = controller.Get();

            //Assert
            Assert.IsType(typeof(string), result);

        }
    }
}
