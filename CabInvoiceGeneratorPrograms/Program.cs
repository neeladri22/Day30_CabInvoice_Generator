using System;

namespace CabInvoiceGeneratorPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cab Invoice Generator Program");

            CabInvoiceGenerator cabInvoiceGenerator = new CabInvoiceGenerator(RideType.NORMAL);
            Console.WriteLine(cabInvoiceGenerator.CalculateFare(10, 15));
            Console.ReadLine();
        }
    }
}
