using System;
using System.Collections.Generic;
using System.Text;

namespace QualityMeasurement
{
    /// <summary>
    /// int kilogram class
    /// </summary>
   public class Kilogram
   {
        ///<summary>
        ///int kilogram property
        ///</summary>
        public int kg;
        ///<summary>
        ///int kilogram construtor
        ///</summary>
        public Kilogram()
        {

        }
        ///<summary>
        ///int kilogram constructor with one parameter=kg
        ///</summary>
        public Kilogram(int kg)
        {
            this.kg = kg;
        }
        ///<summary>
        ///adding equal value method with null parameters
        ///</summary>
        public int EqualsValue()
        {
            return this.kg;
        }
        ///<summary>
        ///adding equals method with one parameter=obj
        ///</summary>
        public override bool Equals(object obj)
        {
            if ((obj == null) || Object.ReferenceEquals(this, obj) || this.GetType().Equals(obj.GetType()))
                return true;

            return false;
        }

    }
}
