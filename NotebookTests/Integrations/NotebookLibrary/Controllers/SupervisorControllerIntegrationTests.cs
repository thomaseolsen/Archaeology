using NotebookLibrary.Controllers;
using NotebookLibrary.Models;
using System;
using System.Linq;
using Xunit;

namespace NotebookTests.Integrations.NotebookLibrary.Controllers
{
    public class SupervisorControllerIntegrationTests : IDisposable
    {
        SupervisorController controller;
        public SupervisorControllerIntegrationTests() {
            controller = new SupervisorController();
        }

        public void Dispose() {
            // Dispose of common setup code
        }

        [Fact]
        public void readSupervisors() {
            var supervisors = controller.readSupervisors();
            Assert.NotEmpty(supervisors);
        }

        [Fact]
        public void readSupervisor() {
            var supervisor = controller.readSupervisor(new Guid("537383c4-59e3-44af-a264-ed3d3b58f876"));
            Assert.Equal("Cherie Lynn", supervisor.FirstName);
            Assert.Equal("Testing Team", supervisor.Team.Name);
        }

        [Fact]
        public void CRUDSupervisor() {
            var newGuid = Guid.NewGuid();
            //System.Console.WriteLine("createSupervisor");
            var createSupervisor = new Supervisor {
                Id = newGuid,
                FirstName = "Thomas",
                MiddleName = "Erik",
                LastName = "Olsen",
                Initials = "TEO",
                Email = "tolsen@southern.edu",
                TeamId = new Guid("39742ce2-283a-47dd-920b-f32942102c94")
            };
            Assert.True(controller.createSupervisor(createSupervisor));

            //System.Console.WriteLine("readSupervisor");
            var readSupervisor = controller.readSupervisor(newGuid);
            Assert.Equal("Thomas", readSupervisor.FirstName);

            //System.Console.WriteLine("updateSupervisor");
            var updateSupervisor = controller.readSupervisor(newGuid);
            updateSupervisor.FirstName = "Silas";
            updateSupervisor.MiddleName = "Tucker";
            updateSupervisor.Initials = "STO";
            controller.updateSupervisor(updateSupervisor);
            readSupervisor = controller.readSupervisor(newGuid);
            Assert.Equal("Silas", readSupervisor.FirstName);
            Assert.Equal("Tucker", readSupervisor.MiddleName);
            Assert.Equal("STO", readSupervisor.Initials);

            //System.Console.WriteLine("deleteSupervisor");
            var deleteSupervisor = controller.readSupervisor(newGuid);
            controller.deleteSupervisor(deleteSupervisor);
            readSupervisor = controller.readSupervisor(newGuid);
            Assert.Null(readSupervisor.FirstName);
        }
    }
}
