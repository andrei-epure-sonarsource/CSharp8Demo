using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haken.CSharp8Demo
{
    public class NullCoallescingAssignment
    {
        public static void Demo(string? s)
		{
			object? o = null;
			var something = new object();


			// pre-C# 8.0
			if (o == null)
			{
				o = something;
			}

			// C# 8.0 - Null Coallescing Assignment Operator ??=
			s ??= "Hello";

			Console.WriteLine(o);
			Console.WriteLine(s);
		}
    }
}
