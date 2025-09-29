using Dino_API_Domain.Commands;
using Dino_API_Domain.Entities;
using Dino_API_Domain.Queries;
using Dino_API_Tools_CQS.Commands;
using Dino_API_Tools_CQS.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dino_API_Domain.Repositories
{
    public interface IDinoRepository :
        ICommandHandler<CreateDinoCommand>,
        IQueryHandler<GetAllDinoQuery, IEnumerable<Dino>>
    {
    }
}
