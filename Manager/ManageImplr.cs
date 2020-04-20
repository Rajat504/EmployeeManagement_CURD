using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manager
{
   public class ManageImplr : IManager
   {
        private IRepository repo;

        public ManageImplr(IRepository repo)
        {
            this.repo = repo;
        }

        public decimal CentimeterTometer(conversion value)
        {
            return this.repo.CentimeterToMeter(value);
        }

        public decimal FeetToInch(conversion value)
        {
            return this.repo.FeetToInch(value);
        }

        public decimal GramToKilogram(conversion Value)
        {
            return this.repo.GramToKilogram(Value);
        }

        public decimal InchToFeet(conversion value)
        {
            return this.repo.InchToFeet(value);
        }

        public decimal KilogramToGram(conversion Value)
        {
            return this.KilogramToGram(Value);
        }

        public decimal MeterToCentimeter(conversion value)
        {
            return this.MeterToCentimeter(value);
        }
    }
}
