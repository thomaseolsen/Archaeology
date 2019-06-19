using System;
using static Newtonsoft.Json.JsonConvert;

namespace NotebookLibrary
{
    public class DataStoreInfo
    {
        public string ServerAddress { get; set; } = "";
        public string ServerUsername { get; set; } = "";
        public string ServerPassword { get; set; } = "";
        public string ServerConnectionString => $"{ServerAddress} {ServerUsername} {ServerPassword}";

        public DataStoreInfo() {

        }

        public int AdderSample(int left, int right) =>
            DeserializeObject<int>($"{left + right}");
    }
}
