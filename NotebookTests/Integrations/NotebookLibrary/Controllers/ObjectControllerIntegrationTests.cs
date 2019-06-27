using NotebookLibrary.Controllers;
using NotebookLibrary.Models;
using System;
using System.Linq;
using Xunit;

namespace NotebookTests.Integrations.NotebookLib.Controllers
{
    public class ObjectControllerIntegrationTests : IDisposable
    {
        ObjectController controller;
        public ObjectControllerIntegrationTests() {
            controller = new ObjectController();
        }

        public void Dispose() {
            // Dispose of common setup code
        }

        [Fact]
        public void readObjects() {
            var objects = controller.readObjects();
            Assert.NotEmpty(objects);
        }

        [Fact]
        public void readObject() {
            var obj = controller.readObject(new Guid("c4ceff30-11c0-450c-9eb5-333982648af4"));
            Assert.Equal(123, obj.Number);
            Assert.Equal(7777, obj.GeospatialData.Number);
            Assert.Equal(77, obj.Locus.Number);
            Assert.Equal("Ab123", obj.Locus.Square.Name);
            Assert.Equal("Cherie Lynn", obj.Locus.Square.Supervisor.FirstName);
        }

        [Fact]
        public void CRUDObject() {
            var newGuid = Guid.NewGuid();
            //System.Console.WriteLine("createObject");
            var createObject = new NotebookLibrary.Models.Object {
                Id = newGuid,
                LocusId = new Guid("21385a91-ef2e-494d-8c0b-50fddcf322c0"),
                Number = 133,
                DateCollected = DateTime.Now,
                GeospatialDataId = new Guid("17cd91d4-d1fb-4ac9-96e3-83e661e4ff00"),
                CountTotal = 1,
                LeftInField = false,
                Remarks = "Iron Arrowhead"

            };
            Assert.True(controller.createObject(createObject));

            //System.Console.WriteLine("readObject");
            var readObject = controller.readObject(newGuid);
            Assert.Equal(133, readObject.Number);

            //System.Console.WriteLine("updateObject");
            var updateObject = controller.readObject(newGuid);
            updateObject.Remarks = "Worked Flint";
            controller.updateObject(updateObject);
            readObject = controller.readObject(newGuid);
            Assert.Equal("Worked Flint", readObject.Remarks);

            //System.Console.WriteLine("deleteObject");
            var deleteObject = controller.readObject(newGuid);
            controller.deleteObject(deleteObject);
            readObject = controller.readObject(newGuid);
            Assert.Equal(new Guid("00000000-0000-0000-0000-000000000000"), readObject.Id);
        }
    }
}
