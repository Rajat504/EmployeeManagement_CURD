using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class conversion
    {
        private decimal inch;

        private decimal feet;

        private decimal kilogram;

        private decimal gram;

        private decimal meter;

        private decimal centiMeter;

        public decimal Feet
        {
            get
            {
                return this.feet;
            }
            set
            {
                this.feet = value;
            }
        }

        public decimal Inch
        {
            get
            {
                return this.inch;
            }
            set
            {
                this.inch = value;
            }
        }

        public decimal KiloGram
        {
            get
            {
                return this.kilogram;
            }
            set
            {
                this.kilogram = value;
            }
        }

        public decimal Gram
        {
            get
            {
                return this.gram;
            }
            set
            {
                this.gram = value;
            }
        }

        public decimal Meter
        {
            get
            {
                return this.meter;
            }
            set
            {
                this.meter = value;
            }
        }

        public decimal CentiMeter
        {
            get
            {
                return this.centiMeter;
            }
            set
            {
                this.centiMeter = value;
            }
        }
    }
}
