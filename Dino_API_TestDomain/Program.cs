using Dino_API_Domain.Commands;
using Dino_API_Domain.Entities;
using Dino_API_Domain.Queries;
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



            //Console.WriteLine("Valeur ConnectionString : " + configuration.GetConnectionString("localDb"));


            ServiceCollection serviceCollection = new();

            serviceCollection.AddSingleton<IConfiguration>(configuration);

            serviceCollection.AddScoped<IDinoRepository, DinoService>();

            ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

            IDinoRepository dinoRepository = serviceProvider.GetService<IDinoRepository>();


            #region Create Dino

            //CreateDinoCommand newDino = new CreateDinoCommand("Triceratops", 6000, 300.0);
            //Console.WriteLine($"NewDino: {dinoRepository.Execute(newDino)}");

            #endregion

            #region GetAll

            IEnumerable<Dino> dinos;

            dinos = dinoRepository.Execute(new GetAllDinoQuery());

            foreach(Dino dino in dinos)
            {
                Console.WriteLine($"ID: {dino.DinoID},  Espece : {dino.Spece}");
            }

            #endregion

        }
    }
}
