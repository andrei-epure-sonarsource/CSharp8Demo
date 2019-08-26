using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Haken.CSharp8Demo
{
    class Program
    {
        [ExcludeFromCodeCoverage]
        async static Task Main(string[] args)
        {
            //NullableReferenceTypes.Demo();

			Console.WriteLine("\n=== IndicesAndRanges ===");
			IndicesAndRanges.Demo();
            IndicesAndRanges.DeadStore(new int[] { 1,2,3 });

			Console.WriteLine("\n=== SwitchExpressions ===");
			SwitchExpressions.Demo();

			Console.WriteLine("\n=== PatternMatching ===");
			PatternMatching.Demo();

			Console.WriteLine("\n=== StaticLocalFunctions ===");
			StaticLocalFunctions.Demo();

			Console.WriteLine("\n=== UsingDeclarations ===");
			UsingDeclarations.Demo();

			Console.WriteLine("\n=== AsyncStreams ===");
			await AsyncStreams.Demo();

			Console.WriteLine("\n=== TargetTypedNew ===");
			TargetTypedNew.Demo();

			Console.WriteLine("\n=== NullCoallescingAssignment ===");
			NullCoallescingAssignment.Demo(null);

			Console.WriteLine("\n=== DefaultInterfaceMethods ===");
			DefaultInterfaceMethods.Demo();

			Console.WriteLine("\n=== DisposableRefStruct ===");
			DisposableRefStruct.Demo();
		}
	}
}
