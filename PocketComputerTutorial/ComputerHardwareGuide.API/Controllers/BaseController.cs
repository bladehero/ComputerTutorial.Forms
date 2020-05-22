using ComputerHardwareGuide.API.Extensions;
using System.Net.Http;

namespace ComputerHardwareGuide.API.Controllers
{
    public class BaseController
    {
        public static string BaseUrl { get; set; } = "https://localhost:44312/";
        public static HttpClientHandler HttpClientHandler { get; set; } = new HttpClientHandler();
        public string Endpoint { get; set; }

        protected static ApplicationHttpClient ApplicationHttpClient { get; } = new ApplicationHttpClient(HttpClientHandler);

        public BaseController(params string[] endpoints)
        {
            Endpoint = CombineExtension.UrlCombine(endpoints);
        }
    }
}
