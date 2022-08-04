using Newtonsoft.Json;
using System;
using System.IO;
using System.Reflection;

namespace Exchange.Common
{

    public static class Settings
    {

        private static readonly dynamic settingsJson = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/settings" + (IsDevelopment ? ".development" : "production") + ".json"));
        public static bool IsDevelopment { get { return Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development"; } }
        public class RateService
        {
            public static string Fixer = settingsJson.RateService.Fixer;
            public static string ApiKey = settingsJson.RateService.ApiKey;

        }


    }
}
