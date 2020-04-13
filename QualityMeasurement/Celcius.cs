using System;
using System.Collections.Generic;
using System.Text;

namespace QualityMeasurement
{
    /// <summary>
    /// creating Celcius public class
    /// </summary>
    public class Celcius
    {
        ///<summary>
        ///int celcius property
        ///</summary>
        public double celcius;
        ///<summary>
        ///creating public celcius with null parameters
        ///</summary>
        public  Celcius()
        {

        }
        ///<summary>
        ///creating public celcius with parameters
        ///</summary>
        public Celcius(double celcius)
        {
            this.celcius = celcius;
        }
        ///<summary>
        ///creating equals value method
        ///</summary>
        public double EqualsValue()
        {
            return this.celcius;
        }
        ///<summary>
        ///creating equals method
        ///</summary>
        public override bool Equals(object obj)
        {
            if ((obj == null) || Object.ReferenceEquals(this, obj) || this.GetType().Equals(obj.GetType()))
                return true;

            return false;
        }
    }
}
