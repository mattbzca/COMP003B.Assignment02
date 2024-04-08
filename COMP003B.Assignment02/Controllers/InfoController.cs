using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment02.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Hobbies()
        {
            return View();
        }
    }
}
