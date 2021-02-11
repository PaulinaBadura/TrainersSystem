using System;

namespace TrainersClasses
{
    public class clsTrainers
    {
        public bool InStock { get; set; }
        public string Brand { get; set; }
        public int Size { get; set; }
        public decimal Price { get; set; }
        public DateTime DateAdded { get; set; }
        public string Name { get; set; }
        public string Colour { get; set; }

        public bool Find(int testData)
        {
            return true;
        }

       
    }
}