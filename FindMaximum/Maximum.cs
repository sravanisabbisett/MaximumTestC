using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximum
{
    class Maximum
    {
        public int maximumInteger(int x,int y,int z)
        {
            int maximum = x;
            if (y.CompareTo(maximum) > 0)
                maximum = y;
            if (z.CompareTo(maximum) > 0)
                maximum = z;
            return maximum;
        }

        public double MaximumDouble(double x,double y,double z)
        {
            double maximum = x;
            if (y.CompareTo(maximum) > 0)
                maximum = y;
            if (z.CompareTo(maximum) > 0)
                maximum = z;
            return maximum;
        }
    }
}
