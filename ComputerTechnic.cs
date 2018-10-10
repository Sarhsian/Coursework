using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    class ComputerTechnic 
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int ID { get; set; }
        public string Description { get; set; }
        public decimal PriceUAH { get; set; }
        public decimal PriceUSD { get; set; }
        public int AmountInStock { get; set; }

        public ComputerTechnic()
        {
            Name = Randomiser.GetRandomName();
            Model = Randomiser.GetRandomModel();
            PriceUAH = Randomiser.GetPriceUAH();
            PriceUSD = Randomiser.GetPriceUSD();

        }
        public override string ToString()
        {
            return $"Name: {Name}, Model: {Model}, Price UAH = {PriceUAH}, Price USD = {PriceUSD};";
        }
    }
    


}
