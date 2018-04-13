using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chuks.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        // GET: Home


        
        public ActionResult Index()
        {
            if (Request.IsAuthenticated)
            {
                return View();
            }
           else
                return Redirect("http://localhost:53812/LoginAuth/Login");
            
        }
    }
}