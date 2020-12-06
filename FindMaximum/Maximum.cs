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
            public T[] array;
            /// <summary>
            /// Initializes a new instance of the <see cref="GenricMaximum{T}"/> class.
            /// </summary>
            /// <param name="firstValue">The first value.</param>
            /// <param name="secondValue">The second value.</param>
            /// <param name="thirdValue">The third value.</param>
            public GenricMaximum(T[] array)
            {
                this.array = array;
            }
            
            /// <summary>
            /// Sort the elements in an array
            /// </summary>
            /// <param name="values"></param>
            /// <returns></returns>
            public T[] Sort(T[] values)
            {
                Array.Sort(values);
                return values;
            }
            
            /// <summary>
            /// return the maximum value
            /// </summary>
            /// <param name="values"></param>
            /// <returns></returns>
            public T MaxValueInArray(params T[] values)
            {
                T[] sortedArray = Sort(this.array);
                return sortedArray[sortedArray.Length - 1];
            }

            /// <summary>
            /// Return max value
            /// </summary>
            /// <returns></returns>
            public T MaxValue()
            {
                var max = MaxValueInArray(this.array);
                return max;
            }

            /// <summary>
            /// prints the maximum value
            /// </summary>
            public void PrintMaxValue()
            {
                var max = MaxValueInArray(this.array);
                Console.WriteLine("Maximum value is" + max);
            }
        }

    }   
}
