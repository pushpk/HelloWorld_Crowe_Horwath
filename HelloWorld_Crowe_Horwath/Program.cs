using HelloWorld_Crowe_Horwath.AbstractTarget;
using HelloWorld_Crowe_Horwath.Factory;
using HelloWorld_Crowe_Horwath.Helper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using static HelloWorld_Crowe_Horwath.Helper.TargetTypeEnum;

namespace HelloWorld_Crowe_Horwath
{
    public class Program
    {
        public static async Task Main(string[] args)
        {                       
            //Pluggin in Configuration
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            // setting up the service dependencies for this application
            var serviceColletion = new ServiceCollection();
            ConfigureServices(serviceColletion, configuration);
            var services = serviceColletion.BuildServiceProvider();

            // API call
            string apiGreetingResponse = await GetGreetingsFromAPI(configuration);

            //Get Target to write greeting from Config
            ITarget target = services.GetRequiredService<ITarget>();

            // Print message
            target.PrintHelloWorld(apiGreetingResponse);

        }

       

        public static async Task<string> GetGreetingsFromAPI(IConfigurationRoot configuration)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(configuration["APIEndPoint"]))
                {
                    return await response.Content.ReadAsStringAsync();

                }
            }
        }

        private static void ConfigureServices(ServiceCollection serviceColletion, IConfigurationRoot configuration)
        {
            serviceColletion.AddSingleton<ITarget>(TargetFactory.Create(ParseEnumHelper.ParseEnum<TargetTypes>(configuration["Target"])));
        }

       
    }
}
