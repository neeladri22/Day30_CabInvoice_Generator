﻿using System;
using System.Collections.Generic;
using System.Text;
namespace CabInvoiceGeneratorPrograms
{
    public class CabInvoiceGenerator
    {
        public readonly int MINIMUM_FARE;
        public readonly int COST_PER_KM;
        public readonly int COST_PER_MINUTE;

        // Parameterized constructor
        public CabInvoiceGenerator(RideType type)
        {
            if (type.Equals(RideType.NORMAL))
            {
                COST_PER_KM = 10;
                COST_PER_MINUTE = 1;
                MINIMUM_FARE = 5;
            }
        }

        // UC1 - Method to calculate fare for single ride
        public double CalculateFare(int time, double distance)
        {
            double totalFare = 0;
            try
            {
                if (time <= 0)
                    throw new CabInvoiceGeneratorException(CabInvoiceGeneratorException.ExceptionType.INVALID_TIME, "Invalid Time");
                if (distance <= 0)
                    throw new CabInvoiceGeneratorException(CabInvoiceGeneratorException.ExceptionType.INVALID_DISTANCE, "Invalid Distance");
                //Total fare for single ride
                totalFare = (distance * COST_PER_KM) + (time * COST_PER_MINUTE);
                //Comparing minimum fare and calculated fare to return the maximum fare
                return Math.Max(totalFare, MINIMUM_FARE);
            }
            catch (CabInvoiceGeneratorException ex)
            {
                throw ex;
            }
        }

        // UC2 - Method to calculate agreegate fare for multiple rides and return Invoice summary
        public InvoiceSummary CalculateAgreegateFare(Ride[] rides)
        {
            double totalFare = 0;
            if (rides.Length == 0)
                throw new CabInvoiceGeneratorException(CabInvoiceGeneratorException.ExceptionType.NULL_RIDES, "No Rides Found");
            foreach (var ride in rides)
            {
                totalFare += CalculateFare(ride.time, ride.distance);
            }
            //double agreegateFare = Math.Max(totalFare, MINIMUM_FARE);
            return new InvoiceSummary(rides.Length, totalFare);
        }
    }
}
