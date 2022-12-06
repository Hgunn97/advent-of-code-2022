using Microsoft.Extensions.DependencyInjection;

namespace Day1
{
    class Program
    {
        static void Main()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            
            var serviceProvider = serviceCollection.BuildServiceProvider();
            serviceProvider.GetService<App>().Run();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<App>();
        }
    }
}