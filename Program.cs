using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MileageCalculation
{
    class Program
    {
        static void Main(string[] args)
        {

            double MILES_TO_KILOMETERS = 1.609;
            double GALLONS_TO_LITERS = 3.785;

            double KilometersDriven;
            double LitersUsed;

            Console.WriteLine("What is the number of kilometers driven?  ");
            KilometersDriven = Console.Read();

            Console.WriteLine("What is the number of liters of gas purchased? ");
            LitersUsed = Console.Read();

            double MilesDriven = KilometersDriven * MILES_TO_KILOMETERS;
            double GallonsUsed = LitersUsed * GALLONS_TO_LITERS;
            double MilesPerGallon = MilesDriven / GallonsUsed;

            Console.WriteLine("\nThe number of miles driven is " + MilesDriven);
            Console.WriteLine("\nThe number of gallons used is " + GallonsUsed);
            Console.WriteLine("\nThe number of miles per gallon is " + MilesPerGallon);
        }
    }
}
