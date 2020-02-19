using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Cost { get; set; }
        public DateTime ShelfLife { get; set; }

        public Product(string name, int quantity, int cost,
                       DateTime shelfLife)
        {
            Name = name;
            Quantity = quantity;
            Cost = cost;
            ShelfLife = shelfLife;
        }
        public override string ToString()
        {
            return $"Product: {Name}, {Quantity}, {Cost}, {ShelfLife}";
        }
    }
}
