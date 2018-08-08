using System;
using System.IO;

namespace ConsoleDependencyInjection02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // create service collection
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            // create service provider
            var serviceProvider = serviceCollection.BuildServiceProvider();

            // entry to run app
            serviceProvider.GetService<App>().Run();
        }

        private static void ConfigureServices(IServiceCollection serviceCollection)
        {
            // add configured instance of logging
            serviceCollection.AddSingleton(new LoggerFactory()
              .AddConsole()
              .AddDebug());

            // add logging
            serviceCollection.AddLogging();

            // build configuration
            var configuration = new ConfigurationBuilder()
                  .SetBasePath(Directory.GetCurrentDirectory())
                  .AddJsonFile("app-settings.json", false)
                  .Build();

            serviceCollection.AddOptions();

            serviceCollection.Configure<AppSettings>(configuration.GetSection("Configuration"));

            // add services 
            serviceCollection.AddTransient<ITestService, TestService>();

            // add app
            serviceCollection.AddTransient<App>();
        }
    }
}
