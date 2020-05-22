using ComputerHardwareGuide.API.Controllers;
using ComputerHardwareGuide.Models.Components.CPUs;
using ComputerHardwareGuide.Models.Components.GPUs;
using ComputerHardwareGuide.Models.Components.Motherboards;
using ComputerHardwareGuide.Models.Components.PowerUnits;
using ComputerHardwareGuide.Models.Components.RAMs;
using ComputerHardwareGuide.Models.Components.ROMs;
using System.Net.Http;

namespace ComputerHardwareGuide.API
{
    /// <summary>
    /// Core service for getting data using controllers
    /// </summary>
    public static class APIContext
    {
        /// <summary>
        /// Assembly controller
        /// </summary>
        public static AssemblyController Assemblies { get; }
        /// <summary>
        /// Options controller
        /// </summary>
        public static OptionController Options { get; }
        /// <summary>
        /// Components controller
        /// </summary>
        public static ComponentController Components { get; }
        /// <summary>
        /// CPUs controller
        /// </summary>
        public static ReadOnlyBaseComponentController<ComponentCPU> CPUs { get; }
        /// <summary>
        /// RAMs controller
        /// </summary>
        public static ReadOnlyBaseComponentController<ComponentRAM> RAMs { get; }
        /// <summary>
        /// GPUs controller
        /// </summary>
        public static ReadOnlyBaseComponentController<ComponentGPU> GPUs { get; }
        /// <summary>
        /// HDDs controller
        /// </summary>
        public static ReadOnlyBaseComponentController<ComponentHDD> HDDs { get; }
        /// <summary>
        /// SSDs controller
        /// </summary>
        public static ReadOnlyBaseComponentController<ComponentSSD> SSDs { get; }
        /// <summary>
        /// PowerUnits controller
        /// </summary>
        public static ReadOnlyBaseComponentController<ComponentPowerUnit> PowerUnits { get; }
        /// <summary>
        /// Motherboards controller
        /// </summary>
        public static ReadOnlyBaseComponentController<ComponentMotherboard> Motherboards { get; }

        /// <summary>
        /// Starting initializing process
        /// </summary>
        static APIContext()
        {
            Assemblies = new AssemblyController();
            Options = new OptionController();
            Components = new ComponentController();
            CPUs = new ReadOnlyBaseComponentController<ComponentCPU>("cpu");
            RAMs = new ReadOnlyBaseComponentController<ComponentRAM>("ram");
            GPUs = new ReadOnlyBaseComponentController<ComponentGPU>("gpu");
            HDDs = new ReadOnlyBaseComponentController<ComponentHDD>("hdd");
            SSDs = new ReadOnlyBaseComponentController<ComponentSSD>("ssd");
            PowerUnits = new ReadOnlyBaseComponentController<ComponentPowerUnit>("powerunit");
            Motherboards = new ReadOnlyBaseComponentController<ComponentMotherboard>("motherboard");
        }

        /// <summary>
        /// Setting API url for the all controllers
        /// </summary>
        /// <param name="url">Url to API</param>
        public static void SetApiUrl(string url) => BaseController.BaseUrl = url;

        /// <summary>
        /// Custom handlers are implemented using on different platforms
        /// </summary>
        /// <param name="handler">Handler of HTTP client</param>
        public static void SetHandler(HttpClientHandler handler) => 
            BaseController.HttpClientHandler = handler;
    }
}
