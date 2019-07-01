using NotebookLibrary.Controllers;
using NotebookLibrary.Models;
using System;
using Xunit;

namespace NotebookTests.Integrations.NotebookLib.Controllers
{
    public class LstArchitecturalConstructionSupportIntegrationTests : IDisposable
    {
        LstArchitecturalConstructionSupportController controller;
        public LstArchitecturalConstructionSupportIntegrationTests() {
            controller = new LstArchitecturalConstructionSupportController();
        }

        public void Dispose() {
            // Dispose of common setup code
        }

        [Fact]
        public void readArchitecturalConstructionSupports() {
            var actualList = controller.readArchitecturalConstructionSupports();
            Assert.NotEmpty(actualList);
        }

        [Fact]
        public void readArchitecturalConstructionSupport() {
            var actualList = controller.readArchitecturalConstructionSupport(3);
            Assert.Equal("Battered", actualList.Description);
        }
    }
}
