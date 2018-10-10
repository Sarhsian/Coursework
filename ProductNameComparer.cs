using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    class ProductNameComparer : IComparer<ComputerTechnic>
    {
        public int Compare(ComputerTechnic comptechnic, ComputerTechnic otherComptechnic)
        {
            return comptechnic.Name.CompareTo(otherComptechnic.Name);
        }
    }
}
