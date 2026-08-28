using Microsoft.AspNetCore.Mvc;
using vdtLesson03.Models;

namespace vdtLesson03.Controllers
{
    public class VdtProductController : Controller
    {
        public IActionResult Index()
        {
            //tao 1 san pham 
            var product = new VdtProduct()
            {
                productID = "P001",
                productName = "lenovo",
                quanlity = 100,
                price = 1200,
            };

            ViewBag.Product = product;
            ViewData["productVD"] = product;


            return View();
        }
        public IActionResult GetAllProducts()
        {
            //tao moc data
            var products = new List<VdtProduct>
            {
                new VdtProduct { productID = "SP01", productName = "Laptop Dell", quanlity = 10, price = 15000000 },
                new VdtProduct { productID = "SP02", productName = "Laptop Asus", quanlity = 8, price = 13500000 },
                new VdtProduct { productID = "SP03", productName = "Chuột Logitech", quanlity = 25, price = 450000 },
                new VdtProduct { productID = "SP04", productName = "Bàn phím cơ", quanlity = 15, price = 850000 },
                new VdtProduct { productID = "SP05", productName = "Tai nghe Bluetooth", quanlity = 20, price = 650000 },
                new VdtProduct { productID = "SP06", productName = "Màn hình Samsung", quanlity = 12, price = 4200000 },
                new VdtProduct { productID = "SP07", productName = "USB 64GB", quanlity = 30, price = 250000 },
                new VdtProduct { productID = "SP08", productName = "Ổ cứng SSD 512GB", quanlity = 18, price = 1250000 },
                new VdtProduct { productID = "SP09", productName = "Webcam Logitech", quanlity = 14, price = 950000 },
                new VdtProduct { productID = "SP10", productName = "Loa Bluetooth", quanlity = 16, price = 750000 }
            };
            //luu vao doi tuong viewdata de chuyen len view
            ViewData["products"] = products;
            return View("Products");
        }
    }
}
