using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Chuks.Facebook
{
    public class FacebookHandler: HttpClientHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (!request.RequestUri.AbsolutePath.Contains("/oauth"))
            {
                request.RequestUri = new Uri(request.RequestUri.AbsoluteUri.Replace("?access_token","&access_token"));
            }
            return base.SendAsync(request, cancellationToken);
        }
    }
   
}