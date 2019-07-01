using NotebookLibrary.Controllers;
using NotebookLibrary.Models;
using System;
using Xunit;

namespace NotebookTests.Integrations.NotebookLib.Controllers
{
    public class LstArchitecturalConstructionStyleIntegrationTests : IDisposable
    {
        LstArchitecturalConstructionStyleController controller;
        public LstArchitecturalConstructionStyleIntegrationTests() {
            controller = new LstArchitecturalConstructionStyleController();
        }

        public void Dispose() {
            // Dispose of common setup code
        }

        [Fact]
        public void readArchitecturalConstructionStyles() {
            var actualList = controller.readArchitecturalConstructionStyles();
            Assert.NotEmpty(actualList);
        }

        [Fact]
        public void readArchitecturalConstructionStyle() {
            var actualList = controller.readArchitecturalConstructionStyle(7);
            Assert.Equal("Tied-in Bricks", actualList.Description);
        }
    }
}
