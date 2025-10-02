using Dino_API_Domain.Entities;
using Dino_API_Tools_CQS.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dino_API_Domain.Queries
{
    public class GetDinoQuery: IQueryDefinition<Dino>
    {
        public int Id { get; set; }
        public GetDinoQuery(int Id)
        {
            this.Id = Id;
        }
    }
}
