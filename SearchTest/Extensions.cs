#region Header
// SearchTest >SearchTest >Extensions.cs\n Copyright (C) , 2021\nCreated 18 01, 2021
#endregion

using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchTest {
    internal static class Extensions {
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

        public static int LinearSearch(this IEnumerable< int > i, int value) {
            return i.FirstOrDefault(t => t == value);
        }

        public static int BinarySearch(this int[] i, int value) {
            int lb = 0;
            int ub = i.GetUpperBound(0);

            while (lb <= ub) {
                
                int mid = ( lb + ub ) / 2;
                if (value == i[ mid ]) {
                    return i[mid];
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
    }
}