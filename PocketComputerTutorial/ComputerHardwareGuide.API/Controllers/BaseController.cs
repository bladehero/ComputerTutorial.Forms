using ComputerHardwareGuide.API.Extensions;
using System.Net.Http;

namespace ComputerHardwareGuide.API.Controllers
{
    /// <summary>
    /// Implements base logic for controller's family
    /// </summary>
    public class BaseController
    {
        /// <summary>
        /// API Url
        /// </summary>
        public static string BaseUrl { get; set; }

        /// <summary>
        /// HTTP handler
        /// </summary>
        public static HttpClientHandler HttpClientHandler { get; set; } = new HttpClientHandler();

        /// <summary>
        /// Additional point on API
        /// </summary>
        public string Endpoint { get; set; }

        /// <summary>
        /// Application handler
        /// </summary>
        protected static ApplicationHttpClient ApplicationHttpClient { get; } = new ApplicationHttpClient(HttpClientHandler);

        public BaseController(params string[] endpoints)
        {
            Endpoint = CombineExtension.UrlCombine(endpoints);
        }
    }
}
