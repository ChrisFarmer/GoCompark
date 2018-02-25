using System.Web.Mvc;
using Domain;

namespace GoCompark.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Booking booking)
        {
            return Index();
        }
    }
}