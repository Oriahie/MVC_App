using Chuks.Models;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace Chuks.Controllers
{
    
    public class LoginAuthController : Controller
    {


        //public ActionResult Login(LoginInfo data)
        //{
        //    var username = data.Username;
        //    return View(data.);
        //}

        
            [HttpGet]
        public ActionResult Login()
        {
            
                return View();
        }

        [HttpPost]
        public ActionResult Login(LoginInfo loginInfo, string returnUrl)
        {
            
            var username = "omni3x@ymail.com";
            var password = "password";
            if (ModelState.IsValid)
            {
                if (username.Equals(loginInfo.Username) && (password.Equals(loginInfo.Password)))
                {
                    ClaimsIdentity claimsIdentity = new ClaimsIdentity("ApplicationCookie");
                    claimsIdentity.AddClaim(new Claim(ClaimTypes.Name, username));
                    var context = Request.GetOwinContext();
                    context.Authentication.SignIn(claimsIdentity);
                    return Redirect(GetRedirectUrl(returnUrl));
                }
                else
                    ModelState.AddModelError("", "Oga you no get sense???");
            }
            return View(loginInfo);

        }

        public ActionResult Signout()
        {
            var context = Request.GetOwinContext();
            context.Authentication.SignOut("ApplicationCookie");
            return Redirect("Login");
        }


        public ActionResult Signup()
        {
            return View();
        }

        private string GetRedirectUrl(string returnUrl)
        {
            if (string.IsNullOrEmpty(returnUrl) || !Url.IsLocalUrl(returnUrl))
            {
                return Url.Action("Index", "Home");
            }

            return returnUrl;
        }

    }
}
