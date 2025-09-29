using Dino_API_Domain.Commands;
using Dino_API_Domain.Entities;
using Dino_API_Domain.Mappers;
using Dino_API_Domain.Queries;
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

        public bool Execute(CreateDinoCommand entity)
        {
            using (SqlConnection connection = new(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO Dino (Spece, Weight, Size) " +
                        "OUTPUT inserted.Id " +
                        "VALUES (@Spece, @Weight, @Size)";
                    command.Parameters.AddWithValue("Spece", entity.Spece);
                    command.Parameters.AddWithValue("Weight", entity.Weight);
                    command.Parameters.AddWithValue("Size", entity.Size);


                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }

                }

            }
        }

        public IEnumerable<Dino> Execute(GetAllDinoQuery query)
        {
            using (SqlConnection connection = new(_connectionString))
            {
                using(SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Dino";

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToDino();
                        }
                    }
                }
            }
        }
    }
}
