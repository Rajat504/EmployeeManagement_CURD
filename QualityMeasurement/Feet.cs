using System;

namespace NUnit_QualityMeasurement
{
    public class Feet
    {
        public int feet;
        public int convertfeettoinch;

        public Feet()
        {
        }

        public Feet(int feet)
        {
            this.feet = feet;
        }

        public int EqualsValue()
        {
            return this.feet;
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || Object.ReferenceEquals(this, obj) || this.GetType().Equals(obj.GetType()))
                return true;

            return false;
        }
    }
}