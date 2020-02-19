using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TrainingGroup
    {
        public int Cipher { get; set; }
        public int NumberOfStudents { get; set; }
        public int YearOfFormation { get; set; }
        public string Specialty { get; set; }

        public TrainingGroup(int cipher, int numberOfStudents,
                             int yearOfFormation, string specialty)
        {
            Cipher = cipher;
            NumberOfStudents = numberOfStudents;
            YearOfFormation = yearOfFormation;
            Specialty = specialty;
        }
        public override string ToString()
        {
            return $"TrainingGroup: {Cipher}, {NumberOfStudents}, {YearOfFormation}, {Specialty}";
        }
    }
}
