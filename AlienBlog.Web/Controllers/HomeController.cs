using System.Web.Mvc;

namespace AlienBlog.Web.Controllers
{
    public class HomeController : AlienBlogControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}