using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manager
{
   public interface IManager
   {
        decimal FeetToInch(conversion value);
        decimal InchToFeet(conversion value);
        decimal MeterToCentimeter(conversion value);
        decimal CentimeterTometer(conversion value);
        decimal KilogramToGram(conversion Value);
        decimal GramToKilogram(conversion Value);

   }
}
