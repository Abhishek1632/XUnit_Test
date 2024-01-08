using XUnitExample.Controllers;

namespace XUnit_Test
{
    public class HomeControllerTest
    {
        [Fact]
        public void HomeController_Index_ValidateResult()
        {
            //AAA

            // Arrange
            HomeController controller = new HomeController();
            string expected = "Hello Abhishek";

            // Act 
            string result = controller.Index();

            // Assert
            Assert.Equal(expected, result);

        }
    }
}