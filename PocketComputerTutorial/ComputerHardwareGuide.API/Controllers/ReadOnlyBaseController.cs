using ComputerHardwareGuide.API.Extensions;
using ComputerHardwareGuide.Models.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ComputerHardwareGuide.API.Controllers
{
    /// <summary>
    /// Read-only component for searching components
    /// </summary>
    /// <typeparam name="T">Component</typeparam>
    public class ReadOnlyBaseComponentController<T> : BaseController where T : BaseComponent
    {
        public ReadOnlyBaseComponentController(params string[] endpoints) : base(endpoints) { }

        /// <summary>
        /// Search method for components
        /// </summary>
        /// <param name="dictionary">Options for searching</param>
        /// <returns>Components aligned by options are sent</returns>
        public virtual async Task<BaseApiResponse<IEnumerable<T>>> Get(IEnumerable<KeyValuePair<string, object>> dictionary = null)
        {
            return await ApplicationHttpClient.HttpSendAsync<IEnumerable<T>>(
                CombineExtension.UrlCombine(BaseUrl, Endpoint), 
                queryParameters: dictionary
            );
        }
    }
}
