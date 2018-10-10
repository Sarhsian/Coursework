using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    class Program
    {
        static void Main(string[] args)
        {
            //ComputerTechnic computerTechnic = new ComputerTechnic();
            //Console.WriteLine(computerTechnic.ToString());
            Storage myStorage = new Storage();
            myStorage.SetRandomStorage(30);
            myStorage.PrintStorage();

            //Console.WriteLine( myStorage.GetAmountInStorage("Printer"));
           myStorage.AddComputerTechnic();
            //myStorage.SortByPrice();
            myStorage.PrintStorage();
            List<ComputerTechnic> computerTechnics = new List<ComputerTechnic>();
            Console.WriteLine();
            computerTechnics = myStorage.FindTechnicDescriptionByNameAndModel("123", "123");
            foreach (var item in computerTechnics)
            {
                Console.WriteLine($"DEscription {item.Description}");
            }
        }
    }
}
