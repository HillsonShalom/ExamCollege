using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace ExamCollege.Config
{
    internal static class Services
    {
        public static string GetConnectionString()
        {
            IConfiguration builder = new ConfigurationBuilder()
 .AddJsonFile("Config/secret.json", optional: true) // Add secrets.json
 .Build();
            // Read a value from the configuration
            return builder["ConnectionString"];
        }
    }
}
