using Microsoft.AspNetCore.Mvc;

namespace XUnitExample.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class HomeController : Controller
    {
        [HttpGet("index/{guessedNumber}")]
        public string Index(int guessedNumber)
        {
            if (guessedNumber < 100)
            {
                return "Wrong! Try a bigger number.";
            }
            else if(guessedNumber >100)
            {
                return "Wring! Try a smaller number.";
            }
            else
            {
                return "You guessed correct number";
            }
        }
    }
}
