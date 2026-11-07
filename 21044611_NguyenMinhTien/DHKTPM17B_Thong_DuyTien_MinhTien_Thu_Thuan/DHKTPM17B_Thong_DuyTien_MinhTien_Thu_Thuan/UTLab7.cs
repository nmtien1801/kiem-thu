using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DHKTPM17B_Thong_DuyTien_MinhTien_Thu_Thuan
{
    [TestClass]
    public class UTLab7
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            Int32[] ints = { 1, 2, 3, 4, 5 };
            Int32 actual = o.Largest(ints);
            Int32 expectedResult = 5;
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            Int32[] ints = { };
            Int32 actual = o.Largest(ints);
            Int32 expectedResult = int.MaxValue;
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            Int32[] ints = { -2147483648, 10, 15, 5 };
            Int32 actual = o.Largest(ints);
            Int32 expectedResult = 15;
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            Int32[] ints = { 2147483647, 10, 15, 5 };
            Int32 actual = o.Largest(ints);
            Int32 expectedResult = 2147483647;
            Assert.AreEqual(expectedResult, actual);
        }
    }
}
