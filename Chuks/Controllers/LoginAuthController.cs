using Chuks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;

namespace Chuks.Controllers
{
    [AllowAnonymous]
    public class LoginAuthController : Controller
    {


        //public ActionResult Login(LoginInfo data)
        //{
        //    var username = data.Username;
        //    return View();
        //}

        // Http GET

        
        public ActionResult Login()
            {
            
                return View();
            }
        
    }
}
