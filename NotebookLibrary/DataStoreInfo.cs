using System;
using static Newtonsoft.Json.JsonConvert;

namespace NotebookLibrary
{
    public class DataStoreInfo
    {
        public string Database { get; set; } = "";
        public string ServerAddress { get; set; } = "";
        public string ServerUsername { get; set; } = "";
        public string ServerPassword { get; set; } = "";
        public string ServerConnectionStringTrust => $"Server={ServerAddress}; " +
                                                      "Database={Database}; " +
                                                      "Trusted_Connection=True;";

        public string ServerConnectionStringUserPass => $"Server={ServerAddress}; " +
                                                         "Database={Database}; " +
                                                         "User={ServerUsername}; " +
                                                         "Password={ServerPassword};";

        public DataStoreInfo() {

        }

        public int AdderSample(int left, int right) => DeserializeObject<int>($"{left + right}");
    }
}
