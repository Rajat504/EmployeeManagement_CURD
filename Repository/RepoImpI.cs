using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
  public  class RepoImpI : IRepository
    {
        public decimal FeetToInch(conversion value)
        {
            return value.Feet * 12;
        }
        public decimal InchToFeet(conversion value)
        {
            return value.Inch / 12;
        }
        public decimal MeterToCentimeter(conversion value)
        {
            return value.Meter * 100;
        }
        public decimal CentimeterToMeter(conversion value)
        {
            return value.CentiMeter / 100;
        }
        public decimal KilogramToGram(conversion value)
        {
            return value.KiloGram * 1000;
        }
        public decimal GramToKilogram(conversion value)
        {
            return value.Gram / 1000;
        }

       
    }

    
}
