using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program reads in a text file that contains the number " +
            "of tickets sold, the number of donations and the expenses " +
            "associated with an event differentiated by code.");
            Console.ReadLine();
            Console.WriteLine("The program lists the amount of the lowest donation, the "
                + "amount of the highest donation, the average donation, " +
                "the number of tickets sold, the number of donations, the " +
                "total income and total expenses and the event profits.");
            Console.ReadLine();
            Console.WriteLine("Please enter the price of a single ticket:  ");
            String price = Console.ReadLine();
            double priceDouble = Convert.ToDouble(price);
            EventClass event = new EventClass(priceDouble);


        }
    }
}
