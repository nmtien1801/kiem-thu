using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MethodLibrary;

namespace DHKTPM17B_Thong_DuyTien_MinhTien_Thu_Thuan
{
    [TestClass]
    public class UTLab8
    {
        [TestMethod]
        public void TestMethod01()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] list = { 3, 4, 2, 1, 7, 5, 6, 8 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8 };
            o.QuickSort(list, 1, 3);
            Console.WriteLine(string.Join(", ", list));
            CollectionAssert.AreEqual(expected, list);
        }
        [TestMethod]
        public void TestMethod02()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] list = { };
            Exception expectedException = null;
            try
            {
                o.QuickSort(list, 1, 3);
            }
            catch (Exception ex)
            {
                expectedException = ex;
            }
            Console.WriteLine(string.Join(", ", list));
            Assert.IsNotNull(expectedException);
        }
        [TestMethod]
        public void TestMethod03()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] list = { 3, 4, 2, 1, 7, 5, 6, 8 };
            int[] expected = { 3, 4, 2, 1, 7, 5, 6, 8 };
            o.QuickSort(list, 9, 3);
            Console.WriteLine(string.Join(", ", list));
            CollectionAssert.AreEqual(expected, list);
        }
        [TestMethod]
        public void TestMethod04()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] list = { 3, 4, 2, 1, 7, 5, 6, 8 };
            int[] expected = { 3, 4, 2, 1, 7, 5, 6, 8 };
            o.QuickSort(list, 6, 5);
            Console.WriteLine(string.Join(", ", list));
            CollectionAssert.AreEqual(expected, list);
        }
        [TestMethod]
        public void TestMethod05()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] list = { 3, 4, 2, 1, 7, 5, 6, 8 };
            Exception expectedException = null;
            try
            {
                o.QuickSort(list, -5, 3);
            }
            catch (Exception ex)
            {
                expectedException = ex;
            }
            Console.WriteLine(string.Join(", ", list));
            Assert.IsNotNull(expectedException);
        }
        [TestMethod]
        public void TestMethod06()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] list = { 3, 4, 2, 1, 7, 5, 6, 8 };
            Exception expectedException = null;
            try
            {
                o.QuickSort(list, 1, 9);
            }
            catch (Exception ex)
            {
                expectedException = ex;
            }
            Console.WriteLine(string.Join(", ", list));
            Assert.IsNotNull(expectedException);
        }
        [TestMethod]
        public void TestMethod07()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] list = { 3, 4, 2, 1, 7, 5, 6, 8 };
            int[] expected = { 3, 4, 2, 1, 7, 5, 6, 8 };
            o.QuickSort(list, 1, -5);
            Console.WriteLine(string.Join(", ", list));
            CollectionAssert.AreEqual(expected, list);
        }
        [TestMethod]
        public void TestMethod08()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] list = { 3, 4, 2, 1, 7, 2147483647, 6, 8 };
            int[] expected = { 1, 2, 3, 4, 5, 7, 8, 2147483647 };
            o.QuickSort(list, 1, 3);
            Console.WriteLine(string.Join(", ", list));
            CollectionAssert.AreEqual(expected, list);
        }
        [TestMethod]
        public void TestMethod09()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] list = { 3, 4, 2, 1, 7, -2147483647, 6, 8 };
            int[] expected = { -2147483647, 1, 2, 3, 4, 5, 7, 8 };
            o.QuickSort(list, 1, 3);
            Console.WriteLine(string.Join(", ", list));
            CollectionAssert.AreEqual(expected, list);
        }
        [TestMethod]
        public void TestMethod10()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] list = { 3, 4, 2, 1, 7, 5, 6, 8 };
            int[] expected = { 3, 4, 2, 1, 7, 5, 6, 8 };
            o.QuickSort(list, 0, 3);
            Console.WriteLine(string.Join(", ", list));
            CollectionAssert.AreEqual(expected, list);
        }
        [TestMethod]
        public void TestMethod11()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] list = { 3, 4, 2, 1, 7, 5, 6, 8 };
            int[] expected = { 3, 4, 2, 1, 7, 5, 6, 8 };
            o.QuickSort(list, 4, 5);
            Console.WriteLine(string.Join(", ", list));
            CollectionAssert.AreEqual(expected, list);
        }
        [TestMethod]
        public void TestMethod12()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] list = { 3, 4, 2, 1, 7, 5, 6, 8 };
            int[] expected = { 3, 4, 2, 1, 7, 5, 6, 8 };
            o.QuickSort(list, 0, 0);
            Console.WriteLine(string.Join(", ", list));
            CollectionAssert.AreEqual(expected, list);
        }
        [TestMethod]
        public void TestMethod13()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] list = { 3, 4, 2, 1, 7, 5, 6, 8 };
            int[] expected = { 3, 4, 2, 1, 7, 5, 6, 8 };
            o.QuickSort(list, 5, 7);
            Console.WriteLine(string.Join(", ", list));
            CollectionAssert.AreEqual(expected, list);
        }
        [TestMethod]
        public void TestMethod14()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] list = { 3, 4, 2, 1, 7, 5, 6, 8 };
            int[] expected = { 3, 4, 2, 1, 7, 5, 6, 8 };
            o.QuickSort(list, 8, 5);
            Console.WriteLine(string.Join(", ", list));
            CollectionAssert.AreEqual(expected, list);
        }
        [TestMethod]
        public void TestMethod15()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] list = { 3, 4, 2, 1, 7, 5, 6, 8 };
            int[] expected = { 3, 4, 2, 1, 7, 5, 6, 8 };
            o.QuickSort(list, 5, 5);
            Console.WriteLine(string.Join(", ", list));
            CollectionAssert.AreEqual(expected, list);
        }
        [TestMethod]
        public void TestMethod16()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] list = { 3, 4, 2, 1, 7, 5, 6, 8 };
            Exception expectedException = null;
            try
            {
                o.QuickSort(list, 5, 8);
            }
            catch (Exception ex)
            {
                expectedException = ex;
            }
            Console.WriteLine(string.Join(", ", list));
            Assert.IsNotNull(expectedException);
        }
    }
}
