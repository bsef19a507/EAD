using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthConversion
{
    internal class Length_Feet : Length_Measurement
    {
        public void setLength(double l)
        {
            length_metre = l;
        }
        public double convert()
        {
            double feet = length_metre * 3.281;
            return feet;
        }
    }
}
