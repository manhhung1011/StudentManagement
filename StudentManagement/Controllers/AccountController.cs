using Microsoft.AspNetCore.Mvc;
using YourProject.Models;

namespace YourProject.Controllers
{
    public class AccountController : Controller
    {
        // GET: Hiển thị form
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // POST: Xử lý dữ liệu form
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if (model.Username == "admin" && model.Password == "123")
            {
                ViewBag.Message = "Login success";
            }
            else
            {
                ViewBag.Message = "Login failed";
            }

            return View(model);
        }
    }
}