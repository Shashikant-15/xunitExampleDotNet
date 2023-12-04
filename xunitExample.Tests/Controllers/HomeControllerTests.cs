using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xunitExample.Controllers;

namespace xunitExample.Tests.Controllers
{
    public class HomeControllerTests
    {
        [Fact]
        public void HomeController_Index_ValidReult() 
        {
            // AAA Methodology
            // Arrange

            HomeController controller = new HomeController();
            string expectedResult = "I am in Home";

            //Act
           string result = controller.Index();

            // Assert
            Assert.Equal(expectedResult, result);

        }
    }
}
