using Microsoft.AspNetCore.Mvc;
using MVCXUnit.Controllers;
using System;
using Moq;
using Xunit;

namespace MVCXUnitTest
{
    public class HomeControllerTest
    {
        [Fact]
        public void Index()
        {

            // Arrange
            HomeController controller = new HomeController();
            // Act
            ViewResult result = controller.Index() as ViewResult;
            
            Assert.NotNull(result);

        }

        [Fact]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();
            // Act
            ViewResult result = controller.About() as ViewResult;
            var actual = result.ViewData["Message"];
             // Assert
           Assert.Equal("Your application description page.", actual);
        }

        [Fact]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();
            // Act
            ViewResult result = controller.Contact() as ViewResult;
            // Assert
            Assert.NotNull(result);
        }

    }
}
 