using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    class ProducPriceComparer : IComparer<ComputerTechnic>
    {
        public int Compare(ComputerTechnic computerTechnic, ComputerTechnic otherComputerTechnic)
        {
            if (computerTechnic.PriceUAH < otherComputerTechnic.PriceUAH)
                return 1;
            else if (computerTechnic.PriceUAH > otherComputerTechnic.PriceUAH)
                return -1;
            else return 0;
        }
    }
}
