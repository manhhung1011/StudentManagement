using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.Controllers
{
    public class ProductController : Controller
    {
        public string Detail(int? id)
        {
            if (id == null)
            {
                return "Lỗi: Vui lòng nhập đúng ID sản phẩm!";
            }
            return $"Product ID = {id}";
        }

        public string Category(string? name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return "Lỗi: Vui lòng cung cấp đúng tên danh mục!";
            }
            return $"Category = {name}";
        }
    }
}