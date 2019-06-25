using NotebookLibrary.Controllers;
using NotebookLibrary.Models;
using System;
using System.Linq;
using Xunit;

namespace NotebookTests.Integrations.NotebookLibrary.Controllers
{
    public class LocusControllerIntegrationTests : IDisposable
    {
        LocusController controller;
        public LocusControllerIntegrationTests() {
            controller = new LocusController();
        }

        public void Dispose() {
            // Dispose of common setup code
        }

        [Fact]
        public void readLocuss() {
            var locuss = controller.readLocuss();
            Assert.NotEmpty(locuss);
        }

        [Fact]
        public void readLocus() {
            var locus = controller.readLocus(new Guid("21385a91-ef2e-494d-8c0b-50fddcf322c0"));
            Assert.Equal(77, locus.Number);
            Assert.Equal("Ab123", locus.Square.Name);
            Assert.Equal("Very Clear", locus.SeparationClarity.Description);
        }

        [Fact]
        public void CRUDLocus() {
            var newGuid = Guid.NewGuid();
            //System.Console.WriteLine("createLocus");
            var createLocus = new Locus {
                Id = newGuid,
                SquareId = new Guid("550f69a7-10c9-44f1-846d-e7484188cdca"),
                Number = 73,
                DateOpened = DateTime.Now,
                SeparationClarityId = 3

            };
            Assert.True(controller.createLocus(createLocus));

            //System.Console.WriteLine("readLocus");
            var readLocus = controller.readLocus(newGuid);
            Assert.Equal(73, readLocus.Number);
            Assert.Equal("Ab123", readLocus.Square.Name);
            Assert.Equal("Average", readLocus.SeparationClarity.Description);

            //System.Console.WriteLine("updateLocus");
            var updateLocus = controller.readLocus(newGuid);
            updateLocus.Number = 33;
            controller.updateLocus(updateLocus);
            readLocus = controller.readLocus(newGuid);
            Assert.Equal(33, readLocus.Number);

            //System.Console.WriteLine("deleteLocus");
            var deleteLocus = controller.readLocus(newGuid);
            controller.deleteLocus(deleteLocus);
            readLocus = controller.readLocus(newGuid);
            Assert.Equal(new Guid("00000000-0000-0000-0000-000000000000"), readLocus.Id);
        }
    }
}
