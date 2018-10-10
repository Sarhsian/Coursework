using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    class Randomiser
    {
        public static string[] Names = {"Printer", "Laptop", "Personal Computer(PC)", "Mobile Phone","IP Camera",
            "Router","Tablet","Power Bank","MP3 Player","Music centre"};
        public static string[] Models = { "Samsung","LG","ACER","DELL","Sony","Lenovo" };
        //public string Descriptions;
 
        public static decimal PriceUAHs = new decimal();
        const decimal DOLLAR = 28.66M;
        const int randomID = 10000;
        public static int AmountInStocks;
        private static int RandomTemp;
        static Random myRandom = new Random(); 

        public static string GetRandomName()
        {
            RandomTemp = myRandom.Next(Names.Length-1);
            return Names[RandomTemp];
        }
        public static string GetRandomModel()
        {
            RandomTemp = myRandom.Next(Models.Length - 1);
            return Models[RandomTemp];
        }
        public static decimal GetPriceUAH()
        {
           PriceUAHs = myRandom.Next(100, 1000);           
            return PriceUAHs;
        }
        public static decimal GetPriceUSD()
        {
            return Math.Round(PriceUAHs / DOLLAR, 2);
        }
        public static int GetRandomID()
        {          
            return  myRandom.Next(randomID);
        }


    }
}
