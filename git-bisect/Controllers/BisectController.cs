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
            return View();
        }
    }
}
