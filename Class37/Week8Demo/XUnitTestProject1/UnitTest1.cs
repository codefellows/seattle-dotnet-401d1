using System;
using System.Net;
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
            var result = controller.Get(5);

            //Assert
            Assert.Equal(HttpStatusCode.OK, (HttpStatusCode)sc.StatusCode.Value);
            Assert.IsType(typeof(string), result);

        }
    }
}
