using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    class Storage
    {
        List<ComputerTechnic> ComputerTechnics = new List<ComputerTechnic>();
        
        public void SetRandomBase(int CountOfTechnic)
        {
            for (int i = 0; i < CountOfTechnic; i++)
            {
                ComputerTechnics.Add(new ComputerTechnic());
            }
        }
        public void PrintBase()
        {
            foreach (ComputerTechnic item in ComputerTechnics)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public int GetAmountInStorage(string Name)
        {
            IEnumerable<ComputerTechnic> subset = from c in ComputerTechnics
                                                  where Name == c.Name select c;
            return subset.Count();
        }


    }
}
