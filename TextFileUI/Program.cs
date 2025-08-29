
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace TextFileUI
{
    internal class Program
    {
        private static IConfiguration _config;
        private static string textFile;
        static void Main(string[] args)
        {
            InitilizeConfiguration();
            textFile = _config.GetValue<string>("TextFile");




            Console.ReadLine();
        }

        private static void  InitilizeConfiguration()
        {
            //(string endpointUrl, string primaryKey, string databaseName, string containerName) output;

            var builder = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json");

            _config = builder.Build();
        }
         
    }
}
