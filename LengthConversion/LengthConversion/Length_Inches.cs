using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthConversion
{
    internal class Length_Inches : Length_Measurement
    {
        public void setLength(double l)
        {
            length_metre = l;
        }
        public double convert()
        {
            double inches = length_metre * 39.37;
            return inches;
        }   

    }
}
