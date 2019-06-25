using NotebookLibrary.Controllers;
using NotebookLibrary.Models;
using System;
using System.Linq;
using Xunit;

namespace NotebookTests.Integrations.NotebookLibrary.Controllers
{
    public class AreaControllerIntegrationTests : IDisposable
    {
        AreaController controller;
        public AreaControllerIntegrationTests() {
            controller = new AreaController();
        }

        public void Dispose() {
            // Dispose of common setup code
        }

        [Fact]
        public void readAreas() {
            var areas = controller.readAreas();
            Assert.NotEmpty(areas);
        }

        [Fact]
        public void readArea() {
            var area = controller.readArea(new Guid("b902fcba-a701-425d-a694-ae9505d366eb"));
            Assert.Equal("AA", area.Name);
            Assert.Equal("Test", area.Site.ShortName);
        }

        [Fact]
        public void CRUDArea() {
            var newGuid = Guid.NewGuid();
            //System.Console.WriteLine("createArea");
            var createArea = new Area {
                Id = newGuid,
                SiteId = new Guid("29b6d07b-6eb9-473f-b4b5-8447468f3737"),
                Name = "BB",
                Objective = "Integration Test with Area BB in Site Tel Test"
            };
            Assert.True(controller.createArea(createArea));

            //System.Console.WriteLine("readArea");
            var readArea = controller.readArea(newGuid);
            Assert.Equal("BB", readArea.Name);

            //System.Console.WriteLine("updateArea");
            var updateArea = controller.readArea(newGuid);
            updateArea.Name = "CC";
            controller.updateArea(updateArea);
            readArea = controller.readArea(newGuid);
            Assert.Equal("CC", readArea.Name);

            //System.Console.WriteLine("deleteArea");
            var deleteArea = controller.readArea(newGuid);
            controller.deleteArea(deleteArea);
            readArea = controller.readArea(newGuid);
            Assert.Null(readArea.Name);
        }
    }
}
