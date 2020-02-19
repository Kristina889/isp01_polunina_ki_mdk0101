using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class MonetaryDenomination
    {
        public int SeriesAndNumber { get; set; }
        public int Par { get; set; }
        public string ParString { get; set; }

        public MonetaryDenomination(int seriesAndNumber, int par,
                                    string parString)
        {
            SeriesAndNumber = seriesAndNumber;
            Par = par;
            ParString = parString;
        }
        public override string ToString()
        {
            return $"MonetaryDenomination: {SeriesAndNumber}, {Par}, {ParString} ";
        }
    }
}
