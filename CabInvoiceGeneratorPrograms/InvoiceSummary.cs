using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGeneratorPrograms
{
    public class InvoiceSummary
    {
        public int numOfRides;
        public double totalFare, averageFare;

        public InvoiceSummary(int numOfRides, double totalFare)
        {
            this.numOfRides = numOfRides;
            this.totalFare = totalFare;
            this.averageFare = totalFare / numOfRides;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is InvoiceSummary))
                return false;
            InvoiceSummary invoiceSummary = (InvoiceSummary)obj;
            return this.numOfRides == invoiceSummary.numOfRides && this.totalFare == invoiceSummary.totalFare && this.averageFare == invoiceSummary.averageFare;
        }

        public override string ToString()
        {
            return $"Total number of rides : {this.numOfRides} \nTotalFare ={this.totalFare} \nAverageFare = {this.averageFare}";
        }
    }
}
