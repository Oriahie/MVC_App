using System.Web.Mvc;

namespace Chuks.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        // GET: Home


        
        public ActionResult Index()
        {

            return View();

           // if (Request.IsAuthenticated)
           // {
                
           // }
           //else
           //     return Redirect("http://localhost:53812/LoginAuth/Login");
            
        }

        public ActionResult Chart()
        {
            return View();
        }



    }
}