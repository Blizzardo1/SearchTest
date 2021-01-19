#region Header
// SearchTest >SearchTest >Extensions.cs\n Copyright (C) , 2021\nCreated 18 01, 2021
#endregion

using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchTest {
    internal static class Extensions {
        /// <summary>
        /// Shuffles the Array
        /// </summary>
        /// <param name="i">The array to shuffle</param>
        /// <returns>A happily shuffled array</returns>
        public static int[] Shuffle(this int[] i) {
            int[] n = i;
            for (int x = 0; x < i.Length; x++) {
                int si = Program.Random.Next(0, i.Length - 1);
                int t = n[ x ];
                n[ x ] = n[ si ];
                n[ si ] = t;
            }

            return n;
        }

        /// <summary>
        /// Performs a linear search using LINQ's FirstOrDefault method
        /// </summary>
        /// <param name="i">The array to search</param>
        /// <param name="value">The number to search for</param>
        /// <returns>The searched <see cref="value"/></returns>
        /// <remarks>This is used to see if the value truly exists, else it returns 0 to indicate that the number was not found. 0 might exist in the array as well</remarks>
        public static int LinearSearch(this IEnumerable< int > i, int value) {
            return i.FirstOrDefault(t => t == value);
        }

        /// <summary>
        /// Gets the index of where <see cref="value"/> exists
        /// </summary>
        /// <param name="i">The array to search</param>
        /// <param name="value">The number to search for</param>
        /// <returns>The index of the array <see cref="i"/></returns>
        public static int BinarySearch(this int[] i, int value) {
            int lb = 0;
            int ub = i.GetUpperBound(0);

            while (lb <= ub) {
                int mid = ( lb + ub ) / 2;
                if (value == i[ mid ]) {
                    return mid;
                }

                if (value < i[ mid ]) {
                    ub = mid - 1;
                    continue;
                }
                if (value > i[mid]) {
                    lb = mid + 1;
                }
            }

            return -1;
        }
        
        /// <summary>
        /// Performs a Bubble Sort
        /// </summary>
        /// <param name="i">The array to sort</param>
        /// <returns>A Sorted array</returns>
        /// <remarks>This is costly for extremely large arrays.</remarks>
        public static int[] BubbleSort(this int[] i) {
            int y = 0;
            while (y < i.Length) {
                for (int x = 0; x < i.Length - 1; x++) {
                    if (i[ x ] <= i[ x + 1 ]) continue;
                    int t = i[ x + 1 ];
                    i[ x + 1 ] = i[ x ];
                    i[ x ] = t;
                }

                y++;
            }
            // Hope this works
            return i;
        }
    }
}