using ComputerHardwareGuide.API.Extensions;
using ComputerHardwareGuide.Models.Components;
using ComputerHardwareGuide.Models.Components.CPUs;
using ComputerHardwareGuide.Models.Components.GPUs;
using ComputerHardwareGuide.Models.Components.Motherboards;
using ComputerHardwareGuide.Models.Components.PowerUnits;
using ComputerHardwareGuide.Models.Components.RAMs;
using ComputerHardwareGuide.Models.Components.ROMs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ComputerHardwareGuide.API.Controllers
{
    /// <summary>
    /// Reading component controller 
    /// </summary>
    public class ComponentController : BaseController
    {
        public ComponentController() : base("component") { }

        /// <summary>
        /// Reading from API to get CPU
        /// </summary>
        /// <param name="id">CPU identifier</param>
        /// <returns>CPU component</returns>
        public async Task<BaseApiResponse<ComponentCPU>> GetCPU(int id) => await Get<ComponentCPU>(id);

        /// <summary>
        /// Reading from API to get GPU
        /// </summary>
        /// <param name="id">GPU identifier</param>
        /// <returns>GPU component</returns>
        public async Task<BaseApiResponse<ComponentGPU>> GetGPU(int id) => await Get<ComponentGPU>(id);

        /// <summary>
        /// Reading from API to get RAM
        /// </summary>
        /// <param name="id">RAM identifier</param>
        /// <returns>RAM component</returns>
        public async Task<BaseApiResponse<ComponentRAM>> GetRAM(int id) => await Get<ComponentRAM>(id);

        /// <summary>
        /// Reading from API to get HDD
        /// </summary>
        /// <param name="id">HDD identifier</param>
        /// <returns>HDD component</returns>
        public async Task<BaseApiResponse<ComponentHDD>> GetHDD(int id) => await Get<ComponentHDD>(id);

        /// <summary>
        /// Reading from API to get SSD
        /// </summary>
        /// <param name="id">SSD identifier</param>
        /// <returns>SSD component</returns>
        public async Task<BaseApiResponse<ComponentSSD>> GetSSD(int id) => await Get<ComponentSSD>(id);

        /// <summary>
        /// Reading from API to get Motherboard
        /// </summary>
        /// <param name="id">Motherboard identifier</param>
        /// <returns>Motherboard component</returns>
        public async Task<BaseApiResponse<ComponentMotherboard>> GetMotherboard(int id) => await Get<ComponentMotherboard>(id);

        /// <summary>
        /// Reading from API to get PowerUnit
        /// </summary>
        /// <param name="id">PowerUnit identifier</param>
        /// <returns>PowerUnit component</returns>
        public async Task<BaseApiResponse<ComponentPowerUnit>> GetPowerUnit(int id) => await Get<ComponentPowerUnit>(id);

        protected async Task<BaseApiResponse<T>> Get<T>(int id) where T : BaseComponent, new()
        {
            var dictionary = new Dictionary<string, object>();
            dictionary.Add("id", id);
            dictionary.Add("type", (int)new T().Type);
            return await ApplicationHttpClient.HttpSendAsync<T>(CombineExtension.UrlCombine(BaseUrl, Endpoint), queryParameters: dictionary);
        }
    }
}
