using Model;
using System;
using System.Collections.Generic;
using System.Text;


namespace Repository
{
    public interface IRepository
    {
        decimal FeetToInch(conversion value);
        decimal InchToFeet(conversion value);
        decimal MeterToCentimeter(conversion value);
        decimal CentimeterToMeter(conversion value);
        decimal KilogramToGram(conversion value);
        decimal GramToKilogram(conversion value);
    }
}
