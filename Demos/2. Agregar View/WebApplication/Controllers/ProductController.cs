using System.Collections.Generic;
using System.Web.Mvc;
using WebApplication.Common;

namespace WebApplication.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            var listProduct = new List<Product>();
            return View(listProduct);
        }
        public ActionResult Create( )
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product model)
        {
            return RedirectToAction("List");
            return View("List");
        }
        public ActionResult Detail(int id)
        {
            Product newProduct = new Product();
            return View(newProduct);
        }
    }
}