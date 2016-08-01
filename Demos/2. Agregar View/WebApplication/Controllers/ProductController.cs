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
            return View();
        }
        public ActionResult Create( )
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product model)
        {
            return View();
        }
        public ActionResult Detail(int id)
        {
            return View();
        }
    }
}