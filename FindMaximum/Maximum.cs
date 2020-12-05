﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximum
{
    public class Maximum
    {

        /// <summary>
        /// Finds the maximum integer from three numbers.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="z">The z.</param>
        /// <returns></returns>
        public int maximumInteger(int x, int y, int z)
        {
                int maximum = x;
                if (y.CompareTo(maximum) > 0)
                    maximum = y;
                if (z.CompareTo(maximum) > 0)
                    maximum = z;
                return maximum;
        }
    }
}
