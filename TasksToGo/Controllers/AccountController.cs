using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TasksToGo.Models.AuthModel;
using TasksToGo.ViewModel;

namespace TasksToGo.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public AccountController(
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager
            ) 
        {
            _userManager = userManager;
            _signInManager = signInManager;

        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM obj)
        {
            if (ModelState.IsValid)
            {
                var user = new AppUser
                {
                    
                    Email = obj.Email,
                    Fname = obj.fname,
                    Lname = obj.lname,
                    SurName = obj.surName
                };
                var result = await _userManager.CreateAsync(user, obj.Password);
            }
            return View(obj);
        }
    }
}
