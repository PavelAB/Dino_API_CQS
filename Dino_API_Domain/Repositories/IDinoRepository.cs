using Dino_API_Domain.Commands;
using Dino_API_Tools_CQS.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dino_API_Domain.Repositories
{
    public interface IDinoRepository :
        ICommandHandler<CreateDinoCommand>
    {
    }
}
