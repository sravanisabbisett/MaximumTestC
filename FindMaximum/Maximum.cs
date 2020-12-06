using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximum
{
    public class Maximum
    {

        /// <summary>
        /// Generic class for finding maximum value
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class GenricMaximum<T> where T : IComparable
        {
            public T x, y, z;
            /// <summary>
            /// Initializes a new instance of the <see cref="GenricMaximum{T}"/> class.
            /// </summary>
            /// <param name="firstValue">The first value.</param>
            /// <param name="secondValue">The second value.</param>
            /// <param name="thirdValue">The third value.</param>
            public GenricMaximum(T x, T y, T z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
            /// <summary>
            /// Logic for finding Maximum value.
            /// </summary>
            /// <param name="firstValue">The first value.</param>
            /// <param name="secondValue">The second value.</param>
            /// <param name="thirdValue">The third value.</param>
            /// <returns></returns>
            /// <exception cref="Exception">All three values are same</exception>
            public static T MaxValue(T x, T y, T z)
            {
                T maximum = x;
                if (y.CompareTo(maximum) > 0)
                    maximum = y;
                if (z.CompareTo(maximum) > 0)
                    maximum = z;
                return maximum;

            }


            /// Returns maximum value
            public T MaxMethod()
            {
                T max = GenricMaximum<T>.MaxValue(this.x, this.y, this.z);
                return max;
            }
        }


    }   
}
