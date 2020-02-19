using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Address
    {
        public int PostalCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int House { get; set; }
        public int Flat { get; set; }

        public Address(int postalCode, string city, string street,
                       int house, int flat)
        {
            PostalCode = postalCode;
            City = city;
            Street = street;
            House = house;
            Flat = flat;
        }
        public override string ToString()
        {
            return $"Address: {PostalCode}, {City}, {Street}, {House}, {Flat}";
        }
    }
}
