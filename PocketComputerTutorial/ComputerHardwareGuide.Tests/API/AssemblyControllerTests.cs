using ComputerHardwareGuide.API.Controllers;
using ComputerHardwareGuide.Models;
using ComputerHardwareGuide.Models.Components;
using ComputerHardwareGuide.Models.ViewModels;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace ComputerHardwareGuide.Tests.API
{
    public class AssemblyControllerTests
    {
        const string appUrl = "http://computerguide.somee.com/";
        public AssemblyControllerTests()
        {
            ComputerHardwareGuide.API.APIContext.SetApiUrl(appUrl);
        }

        #region Test Data
        private Assembly GetAssembly() => new AssemblyController().Get().Result.Data?.FirstOrDefault();
        private AssemblyComponent GetAssemblyComponent() =>
            new AssemblyController().Get(GetAssembly().Id).Result.Data?.Assembly?.AssemblyComponents?.FirstOrDefault();
        private AddAssemblyComponentVM MapAddAssemblyComponentVM(AssemblyComponent component) =>
            new AddAssemblyComponentVM
            {
                ComponentId = component.ComponentId,
                Quantity = component.Quantity,
                Type = component.BaseComponent.Type
            };
        private UpdateAssemblyVM MapUpdateAssemblyVM(Assembly assembly) =>
            new UpdateAssemblyVM
            {
                AssemblyId = assembly.Id,
                Name = assembly.Name,
                ToPrice = assembly.ToPrice
            };
        private UpdateAssemblyComponentVM MapUpdateAssemblyComponentVM(AssemblyComponent component) =>
            new UpdateAssemblyComponentVM
            {
                AssemblyComponentId = component.Id,
                Quantity = component.Quantity
            };
        #endregion

        #region Test Methods
        [Fact]
        public async Task GetAssembliesNormalTest()
        {
            // Arrange
            var assemblyController = new AssemblyController();

            // Act
            var result = await assemblyController.Get();

            // Assert
            Assert.True(result.Success);
            Assert.NotNull(result.Data);
        }

        [Fact]
        public async Task GetAssemblyComponentsNormalTest()
        {
            // Arrange
            var assembly = GetAssembly();
            var assemblyController = new AssemblyController();

            // Act
            var result = await assemblyController.Get(assembly.Id);

            // Assert
            Assert.True(result.Success);
            Assert.NotNull(result.Data);
        }

        [Fact]
        public async Task PostAssemblyNormalTest()
        {
            // Arrange
            var assembly = GetAssembly();
            assembly.Id = 0;
            var assemblyController = new AssemblyController();

            // Act
            var result = await assemblyController.Post(assembly);

            // Assert
            Assert.True(result.Success);
            Assert.NotNull(result.Data);
        }

        [Fact]
        public async Task PostAssemblyComponentNormalTest()
        {
            // Arrange
            var component = MapAddAssemblyComponentVM(GetAssemblyComponent());
            var assembly = GetAssembly();
            component.AssemblyId = assembly.Id;
            var assemblyController = new AssemblyController();

            // Act
            var result = await assemblyController.Post(component);

            // Assert
            Assert.True(result.Success);
            Assert.NotNull(result.Data);
        }

        [Fact]
        public async Task PutAssemblyNormalTest()
        {
            // Arrange
            var assembly = MapUpdateAssemblyVM(GetAssembly());
            var assemblyController = new AssemblyController();

            // Act
            var result = await assemblyController.Put(assembly);

            // Assert
            Assert.True(result.Success);
            Assert.NotNull(result.Data);
        }

        [Fact]
        public async Task PutAssemblyComponentNormalTest()
        {
            // Arrange
            var component = MapUpdateAssemblyComponentVM(GetAssemblyComponent());
            var assemblyController = new AssemblyController();

            // Act
            var result = await assemblyController.Put(component);

            // Assert
            Assert.True(result.Success);
            Assert.NotNull(result.Data);
        }
        #endregion
    }
}
