using git_bisect.Models;
using Microsoft.AspNetCore.Mvc;

namespace git_bisect.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BisectController : Controller
    {
        [HttpGet(Name = "Index")]
        public IActionResult Index()
        {
            var result = new ResultModel
            {
                X = 10,
                Y = 2
            };

            result.Substraction = this.Substraction(result.X, result.Y);
            result.Addition = this.Addition(result.X, result.Y);
            result.Multiplication = this.Multiplication(result.X, result.Y);

            return View(result);
        }

        private int Substraction(int x, int y)
        {
            return x - y;
        }

        private int Addition (int x, int y)
        {
            return x - y; // This will contain typo consciously.
        }

        private int Multiplication (int x, int y)
        {
            return x * y;
        }
    }
}
