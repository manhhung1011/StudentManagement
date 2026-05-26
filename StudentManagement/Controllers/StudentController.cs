using Microsoft.AspNetCore.Mvc;
using YourProject.Models;

namespace YourProject.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Info()
        {
            ViewBag.Name = "Đỗ Mạnh Hùng";

            ViewData["Age"] = 20;

            var student = new Student
            {
                Major = "Khoa học máy tính"
            };

            return View(student);
        }
    }
}