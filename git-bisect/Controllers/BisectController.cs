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
            var result = new ResultModel();


            return View(result);
        }
    }
}
