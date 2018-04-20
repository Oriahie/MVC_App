using Chuks.Facebook;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.Facebook;
using Owin;

namespace CyberAcademy.Web
{
    public partial class Startup
    {
        public static void ConfigureAuth(IAppBuilder app)
        {
            var option = new CookieAuthenticationOptions()
            {
                AuthenticationType = "ApplicationCookie",
                CookieName = "CyberAcademy",
                LoginPath = new PathString("/LoginAuth/Login")
            };
            app.UseCookieAuthentication(option);

            ////app.UseGoogleAuthentication(new GoogleOAuth2AuthenticationOptions()
            ////{
            ////    ClientId = "1077626169509-0ikturn4hmi5hm1cuo3rrrt1o2k04br7.apps.googleusercontent.com",
            ////    ClientSecret = "n7lcaV5o4m-ZV9h00LFyleCM"
            //});


            /* var facebook = new FacebookAuthenticationOptions()
            {
                AppId = "579738459085859",
                AppSecret = "307f3e9f6ff18e8a70e72f11852f0be5",
                BackchannelHttpHandler = new FacebookHandler(),
                UserInformationEndpoint= "https://graph.facebook.com/v2.4/me?fields=id,email"
            };

            facebook.Scope.Add("email");
            app.UseFacebookAuthentication(facebook); */
        }
     

    }
    
}