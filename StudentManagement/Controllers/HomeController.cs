using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult News()
        {
            return Content("<h2>News</h2><p>Đây là trang tin tức. Nội dung tin tức sẽ xuất hiện ở đây.</p>", "text/html");
        }
    }
}