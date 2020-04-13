using System;
using System.Collections.Generic;
using System.Text;

namespace QualityMeasurement
{
    /// <summary>
    /// creating Farenheit class
    /// </summary>
   public class Farenheit
   {
        ///<summary>
        ///int farenheit property
        ///</summary>
        public double farenheit;
        ///<summary>
        ///int farenheit construtor with null parameters
        ///</summary>
        public Farenheit()
        {

        }
        ///<summary>
        ///int farenheit with single parameters
        ///</summary>
        public Farenheit(double farenheit)
        {
            this.farenheit = farenheit;
        }
        ///<summary>
        ///applying equal value method 
        ///</summary>
        public double EqualsValue()
        {
            return this.farenheit;
        }
        ///<summary>
        ///applying equals method 
        ///</summary>
        public override bool Equals(object obj)
        {
            if ((obj == null) || Object.ReferenceEquals(this, obj) || this.GetType().Equals(obj.GetType()))
                return true;

            return false;
        }
    }
}
