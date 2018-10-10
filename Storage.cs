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
        
        public void SetRandomStorage(int CountOfTechnic)
        {
            for (int i = 0; i < CountOfTechnic; i++)
            {
                ComputerTechnics.Add(new ComputerTechnic());
            }
        }
        public void PrintStorage()
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
        public void AddComputerTechnic()
        {
            string temp;
            ComputerTechnic AddComputerTech = new ComputerTechnic();
            Console.WriteLine("Enter the ID of product: ");
            temp = Console.ReadLine();
            AddComputerTech.ID = Convert.ToInt32(temp);
            Console.WriteLine("Enter the name of product: ");
            AddComputerTech.Name = Console.ReadLine();
            Console.WriteLine("Enter the model of product: ");
            AddComputerTech.Model = Console.ReadLine();
            Console.WriteLine("Enter the price of product(UAH): ");
            temp = Console.ReadLine();
            AddComputerTech.PriceUAH = Convert.ToInt32(temp);
            AddComputerTech.PriceUSD = Math.Round((AddComputerTech.PriceUAH / Randomiser.DOLLAR), 2);
            ComputerTechnics.Add(AddComputerTech);           
        }
        public void DeleteFromStorage(int ID) => ComputerTechnics.RemoveAll((x) => x.ID == ID);
        public void SortByName() => ComputerTechnics.Sort(new ProductNameComparer());
        public void SortByPrice() => ComputerTechnics.Sort(new ProducPriceComparer());
        public List<ComputerTechnic> FindTechnicDescriptionByNameAndModel(string Name, string Model)
        {
           //List<ComputerTechnic> technics;
           ComputerTechnics.Find((x) => x.Name == Name && x.Model == Model);
            return ComputerTechnics;

        }
    }
}
