using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Shop
    {
        public string Id { get; set; }
        public int NumberOfEmp { get; set; }

        public Shop(string stringCip, int numberOfEmp)
        {
            Id = stringCip;
            NumberOfEmp = numberOfEmp;
        }
        public override string ToString()
        {
            return $"Shop: {Id}, {NumberOfEmp}";
        }
    }
}
