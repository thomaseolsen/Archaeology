using NotebookLibrary;
using System;
using Xunit;

namespace LibraryTests.Units.NotebookLibrary
{
    public class DataStoreInfoTests : IDisposable
    {
        DataStoreInfo dataStore;
        public DataStoreInfoTests() {
            dataStore = new DataStoreInfo();
        }

        public void Dispose() {
            // Dispose of common setup code
        }

        [Fact]
        public void GetSetServerAddressTest() {
            dataStore.ServerAddress = "localhost";
            Assert.Equal("localhost", dataStore.ServerAddress);
        }

        [Fact]
        public void GetSetServerUsernameTest() {
            dataStore.ServerUsername = "sa";
            Assert.Equal("sa", dataStore.ServerUsername);
        }

        [Fact]
        public void GetSetServerPasswordTest() {
            dataStore.ServerPassword = "Admin.P@ssw0rd";
            Assert.Equal("Admin.P@ssw0rd", dataStore.ServerPassword);
        }

        [Fact]
        public void SaveDataStoreInfoTest() {
            // Assert.Equal(1, 0);
        }
    }
}
