using NotebookLibrary.Controllers;
using NotebookLibrary.Models;
using System;
using Xunit;

namespace NotebookTests.Integrations.NotebookLib.Controllers
{
    public class SiteControllerIntegrationTests : IDisposable
    {
        SiteController controller;
        public SiteControllerIntegrationTests() {
            controller = new SiteController();
        }

        public void Dispose() {
            // Dispose of common setup code
        }

        [Fact]
        public void readSites() {
            var sites = controller.readSites();
            Assert.NotEmpty(sites);
        }

        [Fact]
        public void readSite() {
            var site = controller.readSite(new Guid("29b6d07b-6eb9-473f-b4b5-8447468f3737"));
            Assert.Equal("Test", site.ShortName);
        }

        [Fact]
        public void CRUDSite() {
            var newGuid = Guid.NewGuid();
            //System.Console.WriteLine("createSite");
            var createSite = new Site {
                Id = newGuid,
                ShortName = "Test",
                FullName = "Tel Test",
                PublicationName = "Second Expedition to Tel Test"
            };
            Assert.True(controller.createSite(createSite));

            //System.Console.WriteLine("readSite");
            var readSite = controller.readSite(newGuid);
            Assert.Equal("Test", readSite.ShortName);

            //System.Console.WriteLine("updateSite");
            var updateSite = controller.readSite(newGuid);
            updateSite.FullName = "Khirbet Test";
            controller.updateSite(updateSite);
            readSite = controller.readSite(newGuid);
            Assert.Equal("Khirbet Test", readSite.FullName);

            //System.Console.WriteLine("deleteSite");
            var deleteSite = controller.readSite(newGuid);
            controller.deleteSite(deleteSite);
            readSite = controller.readSite(newGuid);
            Assert.Null(readSite.ShortName);
        }
    }
}
