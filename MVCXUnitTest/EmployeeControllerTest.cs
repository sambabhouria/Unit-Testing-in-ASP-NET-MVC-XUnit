using Microsoft.AspNetCore.Mvc;
using MVCXUnit.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MVCXUnitTest
{
   public class EmployeeControllerTest
    {
        [Fact]
        public void Index()
        {
            // Arrange
            EmployeeController controller = new EmployeeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void Employees_ReturnNomberOf_Employees()
        {
            // Arrange
            EmployeeController controller = new EmployeeController();

            // Act
            ViewResult result = controller.Employees() as ViewResult;
            var actual = result.ViewData["NbEmployee"];

            // Assert
            Assert.Equal(4, actual);
        }
    }
}
