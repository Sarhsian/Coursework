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
            myStorage.SetRandomBase(30);
            myStorage.PrintBase();
            Console.WriteLine( myStorage.GetAmountInStorage("Printer"));

        }
    }
}
