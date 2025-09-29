using Dino_API_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dino_API_Domain.Mappers
{
    internal static class Mapper
    {
        internal static Dino ToDino(this IDataRecord record)
        {
            if (record is null) throw new ArgumentNullException(nameof(record));
            return new Dino()
            {
                DinoID = (int)record["Id"],
                Spece = (string)record["Spece"],
                Weight = (double)record["Weight"],
                Size = (double)record["Size"]
            };
        }
    }
}
