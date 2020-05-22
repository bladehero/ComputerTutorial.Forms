using ComputerHardwareGuide.API.Extensions;
using ComputerHardwareGuide.Models;
using ComputerHardwareGuide.Models.Components;
using ComputerHardwareGuide.Models.ViewModels;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ComputerHardwareGuide.API.Controllers
{
    /// <summary>
    /// Implements features CRUD for assembly and components
    /// </summary>
    public sealed class AssemblyController : BaseController
    {
        private const string subEndPoint = "component";

        public AssemblyController() : base("assembly") { }

        /// <summary>
        /// Method of getting assemblies from API
        /// </summary>
        /// <returns>Collection of assemblies and response wrapper</returns>
        public async Task<BaseApiResponse<IEnumerable<Assembly>>> Get()
        {
            return await ApplicationHttpClient.HttpSendAsync<IEnumerable<Assembly>>(CombineExtension.UrlCombine(BaseUrl, Endpoint));
        }

        /// <summary>
        /// Method of getting components from API
        /// </summary>
        /// <param name="id">Assembly identifier</param>
        /// <returns>Collection of components and response wrapper</returns>
        public async Task<BaseApiResponse<GetAssemblyVM>> Get(int id)
        {
            return await ApplicationHttpClient.HttpSendAsync<GetAssemblyVM>(
                CombineExtension.UrlCombine(BaseUrl, Endpoint), id.ToString());
        }

        /// <summary>
        /// Method of creating assembly using API
        /// </summary>
        /// <param name="model">Assembly information</param>
        /// <returns>Returns assembly and response wrapper</returns>
        public async Task<BaseApiResponse<Assembly>> Post(Assembly model)
        {
            return await ApplicationHttpClient.HttpSendAsync<Assembly>(
                CombineExtension.UrlCombine(BaseUrl, Endpoint),
                data: model, method: HttpMethod.Post);
        }

        /// <summary>
        /// Method of creating components using API
        /// </summary>
        /// <param name="model">Component information</param>
        /// <returns>Returns component and response wrapper</returns>
        public async Task<BaseApiResponse<AssemblyComponent>> Post(AddAssemblyComponentVM model)
        {
            return await ApplicationHttpClient.HttpSendAsync<AssemblyComponent>(
                CombineExtension.UrlCombine(BaseUrl, Endpoint), subEndPoint,
                data: model, method: HttpMethod.Post);
        }

        /// <summary>
        /// Method of updating assebmly using API
        /// </summary>
        /// <param name="model">Assembly information</param>
        /// <returns>Returns assebmly and response wrapper</returns>
        public async Task<BaseApiResponse<Assembly>> Put(UpdateAssemblyVM model)
        {
            return await ApplicationHttpClient.HttpSendAsync<Assembly>(
                CombineExtension.UrlCombine(BaseUrl, Endpoint),
                data: model, method: HttpMethod.Put);
        }

        /// <summary>
        /// Method of updating components using API
        /// </summary>
        /// <param name="model">Component information</param>
        /// <returns>Returns component and response wrapper</returns>
        public async Task<BaseApiResponse<AssemblyComponent>> Put(UpdateAssemblyComponentVM model)
        {
            return await ApplicationHttpClient.HttpSendAsync<AssemblyComponent>(
                CombineExtension.UrlCombine(BaseUrl, Endpoint), subEndPoint,
                data: model, method: HttpMethod.Put);
        }

        /// <summary>
        /// Method of deleting assembly from API
        /// </summary>
        /// <param name="assemblyId">Assembly identifier</param>
        /// <returns>Response wrapper</returns>
        public async Task<BaseApiResponse> Delete(int assemblyId)
        {
            var dictionary = new Dictionary<string, object>();
            dictionary.Add("assemblyId", assemblyId);
            return await ApplicationHttpClient.HttpSendAsync<object>(
                CombineExtension.UrlCombine(BaseUrl, Endpoint), 
              queryParameters: dictionary,  method: HttpMethod.Delete);
        }


        /// <summary>
        /// Method of deleting component from assembly using API
        /// </summary>
        /// <param name="assemblyId">Assembly identifier</param>
        /// <param name="componentId">Component identifier</param>
        /// <param name="type">Component type</param>
        /// <returns>Response wrapper</returns>
        public async Task<BaseApiResponse> Delete(int assemblyId, int componentId, int type)
        {
            var dictionary = new Dictionary<string, object>();
            dictionary.Add("assemblyId", assemblyId);
            dictionary.Add("componentId", componentId);
            dictionary.Add("type", type);
            return await ApplicationHttpClient.HttpSendAsync<object>(
                CombineExtension.UrlCombine(BaseUrl, Endpoint), subEndPoint,
              queryParameters: dictionary, method: HttpMethod.Delete);
        }
    }
}
