using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Book
    {
        public string Title { get; set; }
        public string ListOfAutNames { get; set; }
        public double Cost { get; set; }

        public Book(string title, string listOfAutNumes, double cost)
        {
            Title = title;
            ListOfAutNames = listOfAutNumes;
            Cost = cost;
        }
        public override string ToString()
        {
            return $"Book: {Title}, {ListOfAutNames}, {Cost}";
        }
    }
}
