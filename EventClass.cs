using System;

namespace EventManager
{ 

    public class EventClass
    {
        static const int maxNumberDonations = 200;
        private double myTicketPrice;
        private int numberTicketsSold;
        double[] donationsTotal = new double[maxNumberDonations];
        static int donationsNumber;
        private double totalExpenses;

        public EventClass (double ticketPrice)
        {
            myTicketPrice = ticketPrice;
            numberTicketsSold = 0;
            donationsNumber = 0;
            totalExpenses = 0;
        }

        public EventClass()
        {
            myTicketPrice = 0;
            numberTicketsSold = 0;
            donationsNumber = 0;
            totalExpenses = 0;
        }

        public void addTicketsSold (int numberTickets)
        {
            numberTicketsSold += numberTickets;
        }

        public Boolean addDonations (double donationAmount)
        {
            if (donationsNumber >= maxNumberDonations - 1)
            {
                throw new IndexOutofRangeException("The maximum number of donations has been reached.");
            }
            donationsTotal[donationsNumber] = donationAmount;
            donationsNumber++;
            return true;
        }

        public double addExpenses (double expenseAmount)
        {
            totalExpenses += expenseAmount;
            return totalExpenses;
        }

        public int getNumberOfDonations ()
        {
            return donationsNumber;
        }

        public double getTotalTicketSaleIncome()
        {
            return myTicketPrice * numberTicketsSold;
        }

        public double getTotalMoneyDonated()
        {
            double sum = 0;
            for (int i = 0; i < donationsNumber; i++)
            {
                sum = sum + donationsTotal[i];
            }
            return sum;
        }

        public double minDonation()
        {
            double minValue = donationsTotal[0];
            for (int cell = 0; cell < donationsNumber; cell++)
            {
                if (donationsTotal[cell] < minValue)
                {
                    minValue = donationsTotal[cell];
                }
            }
            return minValue;
        }

        public double averageDonation()
        {
            double averageDonation = 0;
            for (int cell = 0; cell < donationsNumber; cell++)
            {
                averageDonation += donationsTotal[cell];
            }
            averageDonation /= donationsNumber;
            return averageDonation;
        }

        public double maxDonation()
        {
            double maxValue = 0;
            for (int cell = 0; cell < donationsNumber; cell++)
            {
                if (donationsTotal[cell] > maxValue)
                {
                    maxValue = donationsTotal[cell];
                }
            }
            return maxValue;
        }

        public void displayValues()
        {
            String divider = "----------";
            Console.WriteLine();
            Console.WriteLine("Event Overall Outcome:  ");
            Console.WriteLine("   Donation Analysis:  ");
            Console.WriteLine("     Lowest Donation:  ", minDonation());
            Console.WriteLine();
            Console.WriteLine("     Average Donations:  ", averageDonation());
            Console.WriteLine("\n     Highest Donations:  ", maxDonation());
            Console.WriteLine("\n Profit/Loss Results:  ");
            Console.WriteLine("     " + numberTicketsSold + " tickets sold");
            Console.WriteLine(getTotalTicketSaleIncome());
            Console.WriteLine("\n     " + getNumberOfDonations());
            Console.WriteLine(" donations ", getTotalMoneyDonated());
            Console.WriteLine(" + ");
            Console.WriteLine(divider);
            Console.WriteLine("     Total income:  ", (getTotalTicketSaleIncome() + getTotalMoneyDonated()));
            Console.WriteLine();
            Console.WriteLine("     Total expenses:  ", totalExpenses);
            Console.WriteLine("-");
            Console.WriteLine(divider);
            Console.WriteLine("     Event profits:  ", (getTotalTicketSaleIncome() + getTotalMoneyDonated() - totalExpenses));
            Console.WriteLine();
        }
    }

}