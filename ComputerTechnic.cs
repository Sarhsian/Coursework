using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    abstract class ComputerTechnic
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public decimal PriceUAH { get; set; }
        public decimal PriceUSD { get; set; }
        public int AmountInStock { get; set; }
    }
}
