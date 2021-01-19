using System;
using System.Diagnostics;
using System.Linq;

namespace SearchTest {
    internal static class Program {
        private static int[] _array = new int[1000000];
        internal static readonly Random Random = new Random();
        private static readonly Stopwatch Stopwatch = new Stopwatch();
        private const int InitialCheckLen = 10;
        
        
        private static void Main(string[] args) {
            Stopwatch.Start();
            for (int i = 0; i < _array.Length; i++) {
                _array[ i ] = i;
            }
            
            Stopwatch.Stop();
            Console.WriteLine($"Time took to initialize Array[{_array.Length}]: {Stopwatch.ElapsedMilliseconds}ms");
            
            Stopwatch.Reset();
            Stopwatch.Start();
            _array = _array.Shuffle().Shuffle();
            Stopwatch.Stop();

            Console.WriteLine($"Time took to shuffle the array twice: {Stopwatch.ElapsedMilliseconds}ms.");

            int a = Random.Next(0, _array.Length);
            Console.WriteLine($"Hunting for {a}");
            
            int ri = Random.Next(0, _array.Length - 1);
            Console.WriteLine($"Sanity check, {_array[ri]}:value == {ri}:index? {(_array[ri] == ri ? "yes": "no")}");
            
            Stopwatch.Reset();
            Stopwatch.Start();
            int x = _array.LinearSearch(a);
            Stopwatch.Stop();
            Console.WriteLine($"Time took to find {a}: {Stopwatch.ElapsedMilliseconds}ms; {a} == {x}? {( a == x ? "yes" : "no" )} ");
            
            Stopwatch.Reset();
            Stopwatch.Start();
            int binarySearch = _array.BinarySearch(a);
            Stopwatch.Stop();
            Console.WriteLine($"Time took to find {a} via BinarySearch: {Stopwatch.ElapsedMilliseconds}ms; {a} == {binarySearch}? {( a == binarySearch ? "yes" : "no, this failed" )} ");
        }
    }
}