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
        public static string[] Descriptions = { "Red", "Blue", "Pink","Yellow","Brown","Violet",
                "Orange","White","Gold","Silver","Bronze"};
        //public string Descriptions;
 
        public static decimal PriceUAHs = new decimal();
        public static decimal DOLLAR = 28.66M;
        const int randomID = 10000;
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
        public static decimal GetPriceUSD() => Math.Round(PriceUAHs / DOLLAR, 2);
        public static int GetRandomID() => myRandom.Next(randomID);
        public static string GetRandomDescription()
        {
            RandomTemp = myRandom.Next(Descriptions.Length - 1);
            return Descriptions[RandomTemp];
        }


    }
}
