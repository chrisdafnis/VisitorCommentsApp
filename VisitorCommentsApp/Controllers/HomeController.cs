using Microsoft.AspNetCore.Mvc;

namespace VisitorCommentsApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}