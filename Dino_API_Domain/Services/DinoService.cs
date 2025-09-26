using Dino_API_Domain.Commands;
using Dino_API_Domain.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dino_API_Domain.Services
{
    public class DinoService : BaseService, IDinoRepository
    {
        private readonly DbConnection _dbConnection;

        public DinoService(IConfiguration configuration): base(configuration, "localDb")
        {
        }

        public bool Execute(CreateDinoCommand command)
        {
            using (SqlConnection connection = new(_connectionString))
            {
                connection.Open();

                Console.WriteLine("DB Connected");
                connection.Close();

            }
            return true;
        }
    }
}
