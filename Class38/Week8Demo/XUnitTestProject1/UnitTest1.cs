using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Net;
using Week8Demo.Controllers;
using Week8Demo.Data;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        // Reference for InMemory Databases: https://docs.microsoft.com/en-us/ef/core/miscellaneous/testing/in-memory
        [Fact]
        public void GetRetunsString()
        {
            var options = new DbContextOptionsBuilder<TodoDbContext>()
            .UseInMemoryDatabase(databaseName: "getStatusCode")
            .Options;

            //Arrange

            using (var context = new TodoDbContext(options))
            {
                var controller = new TasksController(context);

                //Act
                var result = controller.Get(5);
                ObjectResult sc = (ObjectResult)result;

                //Assert
                Assert.Equal(HttpStatusCode.OK, (HttpStatusCode)sc.StatusCode.Value);
                //Assert.IsType(typeof(string), result);
            }





        }
    }
}
