using XUnitExample.Controllers;

namespace XUnit_Test
{
    public class HomeControllerTest
    {
        [Fact]
        public void HomeController_Index_ValidLargeNumberResult()
        {
            //AAA

            // Arrange
            HomeController controller = new HomeController();
            int guessedNumber= 120;
            string expectedResult = "Wrong! Try a smaller number.";

            // Act 
            string result = controller.Index(guessedNumber);

            // Assert
            Assert.Equal(expectedResult, result);

        }


        [Fact]
        public void HomeController_Index_ValidSmallerNumberResult()
        {
            //AAA

            // Arrange
            HomeController controller = new HomeController();
            int guessedNumber = 80;
            string expectedResult = "Wrong! Try a bigger number.";

            // Act 
            string result = controller.Index(guessedNumber);

            // Assert
            Assert.Equal(expectedResult, result);

        }

        [Fact]
        public void HomeController_Index_ValidCorrectNumberResult()
        {
            //AAA

            // Arrange
            HomeController controller = new HomeController();
            int guessedNumber = 100;
            string expectedResult = "You guessed correct number.";

            // Act 
            string result = controller.Index(guessedNumber);

            // Assert
            Assert.Equal(expectedResult, result);

        }
    }
}