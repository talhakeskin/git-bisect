﻿using git_bisect.Models;
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

            result.Addition = this.Addition(result.X, result.Y);

            return View(result);
        }

        private int Addition (int x, int y)
        {
            return x + y; // This will contain typo consciously.
        }
    }
}
