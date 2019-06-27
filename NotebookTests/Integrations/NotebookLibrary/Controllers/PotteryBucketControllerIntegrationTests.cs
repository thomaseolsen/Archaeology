using NotebookLibrary.Controllers;
using NotebookLibrary.Models;
using System;
using System.Linq;
using Xunit;

namespace NotebookTests.Integrations.NotebookLib.Controllers
{
    public class PotteryBucketControllerIntegrationTests : IDisposable
    {
        PotteryBucketController controller;
        public PotteryBucketControllerIntegrationTests() {
            controller = new PotteryBucketController();
        }

        public void Dispose() {
            // Dispose of common setup code
        }

        [Fact]
        public void readPotteryBuckets() {
            var potteryBuckets = controller.readPotteryBuckets();
            Assert.NotEmpty(potteryBuckets);
        }

        [Fact]
        public void readPotteryBucket() {
            var potteryBucket = controller.readPotteryBucket(new Guid("46457623-dcb4-4e69-8c2a-a6d03430b62f"));
            Assert.Equal(122, potteryBucket.Number);
            Assert.Equal(7777, potteryBucket.GeospatialData.Number);
            Assert.Equal(77, potteryBucket.Locus.Number);
            Assert.Equal("Ab123", potteryBucket.Locus.Square.Name);
            Assert.Equal("Cherie Lynn", potteryBucket.Locus.Square.Supervisor.FirstName);
        }

        [Fact]
        public void CRUDPotteryBucket() {
            var newGuid = Guid.NewGuid();
            //System.Console.WriteLine("createPotteryBucket");
            var createPotteryBucket = new PotteryBucket {
                Id = newGuid,
                LocusId = new Guid("21385a91-ef2e-494d-8c0b-50fddcf322c0"),
                Number = 132,
                DateFilled = DateTime.Now,
                GeospatialDataId = new Guid("17cd91d4-d1fb-4ac9-96e3-83e661e4ff00"),
                CountTotal = 200,
                CountRims = 0,
                CountHandles = 0,
                CountBases = 0,
                BoneBag = false,
                Remarks = "LB - NK"

            };
            Assert.True(controller.createPotteryBucket(createPotteryBucket));

            //System.Console.WriteLine("readPotteryBucket");
            var readPotteryBucket = controller.readPotteryBucket(newGuid);
            Assert.Equal(132, readPotteryBucket.Number);

            //System.Console.WriteLine("updatePotteryBucket");
            var updatePotteryBucket = controller.readPotteryBucket(newGuid);
            updatePotteryBucket.Remarks = "LB, Restorable, AK";
            controller.updatePotteryBucket(updatePotteryBucket);
            readPotteryBucket = controller.readPotteryBucket(newGuid);
            Assert.Equal("LB, Restorable, AK", readPotteryBucket.Remarks);

            //System.Console.WriteLine("deletePotteryBucket");
            var deletePotteryBucket = controller.readPotteryBucket(newGuid);
            controller.deletePotteryBucket(deletePotteryBucket);
            readPotteryBucket = controller.readPotteryBucket(newGuid);
            Assert.Equal(new Guid("00000000-0000-0000-0000-000000000000"), readPotteryBucket.Id);
        }
    }
}
