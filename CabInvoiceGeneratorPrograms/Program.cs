using System;

namespace CabInvoiceGeneratorPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cab Invoice Generator Program");

            CabInvoiceGenerator normalCabInvoiceGenerator = new CabInvoiceGenerator(RideType.NORMAL);
            Console.WriteLine("Fare for Normal ride: " + normalCabInvoiceGenerator.CalculateFare(10, 15));

            CabInvoiceGenerator premiumCabInvoiceGenerator = new CabInvoiceGenerator(RideType.PREMIUM);
            Console.WriteLine("Fare for Premium ride: " + premiumCabInvoiceGenerator.CalculateFare(10, 15));

            Ride[] multiRides = { new Ride(10, 15), new Ride(10, 15) };
            Console.WriteLine("\nFare for Normal Multiple ride: \n" + normalCabInvoiceGenerator.CalculateAgreegateFare(multiRides));
            Console.WriteLine("\nFare for Premium Multiple ride: \n" + premiumCabInvoiceGenerator.CalculateAgreegateFare(multiRides));
            Console.ReadLine();
        }
    }
}
