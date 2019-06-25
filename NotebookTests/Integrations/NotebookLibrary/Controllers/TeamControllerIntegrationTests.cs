using NotebookLibrary.Controllers;
using NotebookLibrary.Models;
using System;
using System.Linq;
using Xunit;

namespace NotebookTests.Integrations.NotebookLibrary.Controllers
{
    public class TeamControllerIntegrationTests : IDisposable
    {
        TeamController controller;
        public TeamControllerIntegrationTests() {
            controller = new TeamController();
        }

        public void Dispose() {
            // Dispose of common setup code
        }

        [Fact]
        public void readTeams() {
            var teams = controller.readTeams();
            Assert.NotEmpty(teams);
        }

        [Fact]
        public void readTeam() {
            var team = controller.readTeam(new Guid("39742ce2-283a-47dd-920b-f32942102c94"));
            Assert.Equal("Testing Team", team.Name);
        }

        [Fact]
        public void CRUDTeam() {
            var newGuid = Guid.NewGuid();
            //System.Console.WriteLine("createTeam");
            var createTeam = new Team {
                Id = newGuid,
                Name = "Integration Test"
            };
            Assert.True(controller.createTeam(createTeam));

            //System.Console.WriteLine("readTeam");
            var readTeam = controller.readTeam(newGuid);
            Assert.Equal("Integration Test", readTeam.Name);

            //System.Console.WriteLine("updateTeam");
            var updateTeam = controller.readTeam(newGuid);
            updateTeam.Name = "Int Test";
            controller.updateTeam(updateTeam);
            readTeam = controller.readTeam(newGuid);
            Assert.Equal("Int Test", readTeam.Name);

            //System.Console.WriteLine("deleteTeam");
            var deleteTeam = controller.readTeam(newGuid);
            controller.deleteTeam(deleteTeam);
            readTeam = controller.readTeam(newGuid);
            Assert.Null(readTeam.Name);
        }
    }
}
