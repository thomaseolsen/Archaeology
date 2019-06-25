using NotebookLibrary.Controllers;
using NotebookLibrary.Models;
using System;
using System.Linq;
using Xunit;

namespace NotebookTests.Integrations.NotebookLibrary.Controllers
{
    public class SquareControllerIntegrationTests : IDisposable
    {
        SquareController controller;
        public SquareControllerIntegrationTests() {
            controller = new SquareController();
        }

        public void Dispose() {
            // Dispose of common setup code
        }

        [Fact]
        public void readSquares() {
            var squares = controller.readSquares();
            Assert.NotEmpty(squares);
        }

        [Fact]
        public void readSquare() {
            var square = controller.readSquare(new Guid("550f69a7-10c9-44f1-846d-e7484188cdca"));
            Assert.Equal("Ab123", square.Name);
            Assert.Equal("AA", square.Area.Name);
            Assert.Equal("Cherie Lynn", square.Supervisor.FirstName);
        }

        [Fact]
        public void CRUDSquare() {
            var newGuid = Guid.NewGuid();
            //System.Console.WriteLine("createSquare");
            var createSquare = new Square {
                Id = newGuid,
                AreaId = new Guid("b902fcba-a701-425d-a694-ae9505d366eb"),
                Name = "Bc321",
                SupervisorId = new Guid("537383c4-59e3-44af-a264-ed3d3b58f876"),
                Coordinates = null

            };
            Assert.True(controller.createSquare(createSquare));

            //System.Console.WriteLine("readSquare");
            var readSquare = controller.readSquare(newGuid);
            Assert.Equal("Bc321", readSquare.Name);

            //System.Console.WriteLine("updateSquare");
            var updateSquare = controller.readSquare(newGuid);
            updateSquare.Name = "Cd234";
            controller.updateSquare(updateSquare);
            readSquare = controller.readSquare(newGuid);
            Assert.Equal("Cd234", readSquare.Name);

            //System.Console.WriteLine("deleteSquare");
            var deleteSquare = controller.readSquare(newGuid);
            controller.deleteSquare(deleteSquare);
            readSquare = controller.readSquare(newGuid);
            Assert.Null(readSquare.Name);
        }
    }
}
