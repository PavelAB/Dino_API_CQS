using Dino_API_Domain.Commands;
using Dino_API_Domain.Repositories;
using Dino_API_Domain.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Dino_API_TestDomain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Dino World, console test for domain!");

            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true)
                .Build();

            Console.WriteLine("Valeur ConnectionString : " + configuration.GetConnectionString("localDb"));


            ServiceCollection serviceCollection = new();

            serviceCollection.AddSingleton<IConfiguration>(configuration);

            serviceCollection.AddScoped<IDinoRepository, DinoService>();

            ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

            IDinoRepository dinoRepository = serviceProvider.GetService<IDinoRepository>();

            var test = new CreateDinoCommand("test", 3.0, 3.0);
            dinoRepository.Execute(test);


        }
    }
}
