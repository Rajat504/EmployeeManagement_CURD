using System;
using System.Collections.Generic;
using System.Text;

namespace QualityMeasurement
{
    ///<summary>
    ///Constructing gram class
    ///</summary>
   public class Gram
   {
        ///<sumary>
        ///int gram property
        ///</sumary>
        public int gram;

        ///<summary>
        /// constructing gram constructor
        ///</summary>
        public Gram()
        {

        }
        ///<summary>
        ///constructing gram constructor with one parameter="gram"
        ///</summary>
        public Gram(int gram)
        {
            this.gram = gram;
        }
        ///<summary>
        ///constructing equal value method
        ///</summary>
        ///<return></return>
        public int EqualsValue()
        {
            return this.gram;
        }
        ///<summary>
        ///constructing equals method with one parameter="obj"
        ///</summary>
        public override bool Equals(object obj)
        {
            if ((obj == null) || Object.ReferenceEquals(this, obj) || this.GetType().Equals(obj.GetType()))
                return true;

            return false;
        }

    }
}
