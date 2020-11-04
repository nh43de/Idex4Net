using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Flurl;
using Idex4Net.Domain;
using Newtonsoft.Json;

namespace Idex4Net.Extensions
{
    public static class HttpClientExtensions
    {
        public static Task<HttpResponseMessage> PostAsJsonAsync(this HttpClient httpClient, string url,
            object parameters, bool usePost, CancellationToken cancellationToken)
        {
            if (usePost)
            {
                var content = new StringContent(JsonConvert.SerializeObject(parameters), Encoding.UTF8, "application/json");
                var r = httpClient.PostAsync(url, content, cancellationToken);
                return r;
            }
            else
            {
                var finalUrl = url.SetQueryParams(parameters);

                var r = httpClient.GetAsync(finalUrl, cancellationToken);
                return r;
            }
        }
    }
}