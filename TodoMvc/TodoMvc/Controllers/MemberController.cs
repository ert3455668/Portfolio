using Microsoft.AspNetCore.Mvc;

namespace TodoMvc.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            //我是註解
            return View();
        }

        //回傳Register
        public IActionResult Register()
        {
            return View();
        }
    }
}
