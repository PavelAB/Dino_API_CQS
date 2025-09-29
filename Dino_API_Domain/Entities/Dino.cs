using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dino_API_Domain.Entities
{
    public class Dino
    {
        public int DinoID { get; set; }
        public string Spece {  get; set; }
        public double Weight { get; set; }
        public double Size { get; set; }
    }
}
