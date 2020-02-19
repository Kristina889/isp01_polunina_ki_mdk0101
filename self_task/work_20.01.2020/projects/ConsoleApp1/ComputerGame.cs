using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ComputerGame
    {
        public string Name { get; set; }
        public string DeveloperFirm { get; set; }
        public int PublicationDate { get; set; }
        public string Genre { get; set; }
        public ComputerGame(string name, string developerFirm,
                            int publicationDate, string genre)
        {
            Name = name;
            DeveloperFirm = developerFirm;
            PublicationDate = publicationDate;
            Genre = genre;
        }
        public override string ToString()
        {
            return $"ComputerGame: {Name}, {DeveloperFirm}, {PublicationDate}, {Genre}";
        }
    }
}
