using Dino_API_Tools_CQS.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dino_API_Domain.Commands
{
    public class CreateDinoCommand : ICommandDefinition
    {
        public CreateDinoCommand(string spece, double weight, double size)
        {
            Spece = spece;
            Weight = weight;
            Size = size;
        }

        public string Spece { get; }
        public double Weight { get; }
        public double Size { get; }
    }
}
