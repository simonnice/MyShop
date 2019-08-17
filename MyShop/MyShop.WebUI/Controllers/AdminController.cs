using System.Web.Mvc;

namespace MyShop.WebUI.Controllers
{
    [Authorize(Roles="Admin")]
    public class AdminController : Controller
    {
        // GET
        public ActionResult Index()
        {
            return View();
        }
    }
}