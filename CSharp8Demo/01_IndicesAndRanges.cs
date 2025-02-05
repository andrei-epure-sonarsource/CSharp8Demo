﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haken.CSharp8Demo
{
    public class IndicesAndRanges
    {
        public static void DeadStore(int[] array)
        {
            var x = 0;
            x = array[^1]; // Noncompliant
            try
            {
                x = 11; // Noncompliant
                x = 12;
                Console.Write(x);
                x = 13; // Noncompliant
            }
            catch (Exception)
            {
                x = 21; // Noncompliant
                x = 22;
                Console.Write(x);
                x = 23; // Noncompliant
            }
            x = 31; // Noncompliant
        }


        // broken in VS2019 Prev4/RC: "Missing compiler required member 'System.Range..ctor'" :-)
        public static void Demo()
		{
			int[] a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };


			Index i1 = 3;  // number 3 from beginning (zero-based)
			Index i2 = ^4; // number 4 from end ("hat" operator)

			Console.WriteLine($"{a[i1]}, {a[i2]}"); // "3, 6"


			foreach (var i in a[2..5]) // start index is inclusive, end index is exclusive (non-inclusive)!
			{
				Console.Write(i); // 234
			}
			Console.WriteLine();


			foreach (var i in a[8..^1]) // start index is inclusive, end index is exclusive (non-inclusive)!
			{
				Console.Write(i); // 8
			}
			Console.WriteLine();


			foreach (var i in a[3..]) // start/end index only
			{
				Console.Write(i); // 3456789
			}
			Console.WriteLine();


			foreach (var i in a[..]) // all
			{
				Console.Write(i); // 0123456789
			}
			Console.WriteLine();

		}
	}
}
