using NotebookLibrary.Controllers;
using NotebookLibrary.Models;
using System;
using System.Linq;
using Xunit;

namespace NotebookTests.Integrations.NotebookLib.Controllers
{
    public class GeospatialDataControllerIntegrationTests : IDisposable
    {
        GeospatialDataController controller;
        public GeospatialDataControllerIntegrationTests() {
            controller = new GeospatialDataController();
        }

        public void Dispose() {
            // Dispose of common setup code
        }

        [Fact]
        public void readGeospatialDataEverything() {
            var geospatialData = controller.readGeospatialData();
            Assert.NotEmpty(geospatialData);
        }

        [Fact]
        public void readGeospatialData() {
            var geospatialData = controller.readGeospatialData(new Guid("17cd91d4-d1fb-4ac9-96e3-83e661e4ff00"));
            Assert.Equal(7777, geospatialData.Number);
        }

        [Fact]
        public void CRUDGeospatialData() {
            var newGuid = Guid.NewGuid();
            //System.Console.WriteLine("createGeospatialData");
            var createGeospatialData = new GeospatialData {
                Id = newGuid,
                Number = 3333
            };
            Assert.True(controller.createGeospatialData(createGeospatialData));

            //System.Console.WriteLine("readGeospatialData");
            var readGeospatialData = controller.readGeospatialData(newGuid);
            Assert.Equal(3333, readGeospatialData.Number);

            //System.Console.WriteLine("updateGeospatialData");
            var updateGeospatialData = controller.readGeospatialData(newGuid);
            updateGeospatialData.Number = 3737;
            controller.updateGeospatialData(updateGeospatialData);
            readGeospatialData = controller.readGeospatialData(newGuid);
            Assert.Equal(3737, readGeospatialData.Number);

            //System.Console.WriteLine("deleteGeospatialData");
            var deleteGeospatialData = controller.readGeospatialData(newGuid);
            controller.deleteGeospatialData(deleteGeospatialData);
            readGeospatialData = controller.readGeospatialData(newGuid);
            Assert.Equal(new Guid("00000000-0000-0000-0000-000000000000"), readGeospatialData.Id);
        }
    }
}
