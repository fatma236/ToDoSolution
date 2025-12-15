using Microsoft.AspNetCore.Mvc;

namespace TasksToGo.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
