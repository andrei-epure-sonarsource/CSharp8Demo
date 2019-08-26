using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Haken.CSharp8Demo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IndicesAndRanges.DeadStore(new int[] { 1 });
            IndicesAndRanges.Demo();
            SwitchExpressions.Demo();
            PatternMatching.Demo();
            StaticLocalFunctions.Demo();
            UsingDeclarations.Demo();
            //NullableReferenceTypes.Demo();
            AsyncStreams.Demo();
            TargetTypedNew.Demo();
            DefaultInterfaceMethods.Demo();
            NullCoallescingAssignment.Demo(null);
            MyPoint mp = new MyPoint();
            mp.Translate(10, 12);
            DisposableRefStruct.Demo();
        }
    }
}
