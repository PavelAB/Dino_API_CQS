using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dino_API_Tools_CQS.Queries
{
    public interface IQueryHandler<TQuery, TResult>
        where TQuery: IQueryDefinition<TResult>
    {
        TResult Execute(TQuery query);
    }
}
