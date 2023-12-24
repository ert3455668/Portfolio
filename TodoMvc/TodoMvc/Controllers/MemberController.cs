using Microsoft.AspNetCore.Mvc;

namespace TodoMvc.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //回傳Register
        public IActionResult Register()
        {
            return View();
        }
    }
}
