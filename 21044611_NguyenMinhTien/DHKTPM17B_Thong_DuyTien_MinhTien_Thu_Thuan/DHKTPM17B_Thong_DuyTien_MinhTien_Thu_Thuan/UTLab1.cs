using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DHKTPM17B_Thong_DuyTien_MinhTien_Thu_Thuan
{
    [TestClass]
    public class UTLab1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int a = 2;
            int b = 3;
            int c = 4;
            int max = o.Max(a, b, c);

            int max1 = Math.Max(Math.Max(a, b), c);

            Assert.AreEqual(c, max);
        }


        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int a = 3;
            int b = 3;
            int c = 3;
            int max = o.Max(a, b, c);

            Assert.AreEqual(3, max);
        }
        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int a = -2;
            int b = 2;
            int c = 3;
            int max = o.Max(a, b, c);

            Assert.ThrowsException<Exception>(() => o.Max(a, b, c));
        }
        [TestMethod]
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int a = 55;
            int b = 2;
            int c = 3;
            int max = o.Max(a, b, c);

            Assert.ThrowsException<Exception>(() => o.Max(a, b, c));
        }
        [TestMethod]
        public void TestMethod5()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int a = 1;
            int b = -2;
            int c = 3;
            int max = o.Max(a, b, c);

            Assert.AreEqual(a, max);
        }
        [TestMethod]
        public void TestMethod6()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int a = 1;
            int b = 55;
            int c = 3;
            int max = o.Max(a, b, c);

            Assert.ThrowsException<Exception>(() => o.Max(a, b, c));
        }
        [TestMethod]
        public void TestMethod7()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int a = 1;
            int b = 2;
            int c = -2;
            int max = o.Max(a, b, c);

            Assert.ThrowsException<Exception>(() => o.Max(a, b, c));
        }
        [TestMethod]
        public void TestMethod8()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int a = 1;
            int b = 2;
            int c = 55;
            int max = o.Max(a, b, c);

            Assert.ThrowsException<Exception>(() => o.Max(a, b, c));
        }
        [TestMethod]
        public void TestMethod9()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int a = 1;
            int b = 2;
            int c = 3;
            int max = o.Max(a, b, c);

            Assert.AreEqual(c, max);
        }
        [TestMethod]
        public void TestMethod10()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int a = 50;
            int b = 2;
            int c = 3;
            int max = o.Max(a, b, c);

            Assert.AreEqual(a, max);
        }
        [TestMethod]
        public void TestMethod11()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int a = 1;
            int b = 1;
            int c = 3;
            int max = o.Max(a, b, c);

            Assert.AreEqual(c, max);
        }
        [TestMethod]
        public void TestMethod12()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int a = 1;
            int b = 50;
            int c = 3;
            int max = o.Max(a, b, c);

            Assert.AreEqual(b, max);
        }
        [TestMethod]
        public void TestMethod13()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int a = 3;
            int b = 2;
            int c = 1;
            int max = o.Max(a, b, c);

            Assert.AreEqual(a, max);
        }
        [TestMethod]
        public void TestMethod14()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int a = 1;
            int b = 2;
            int c = 50;
            int max = o.Max(a, b, c);

            Assert.AreEqual(c, max);
        }
        [TestMethod]
        public void TestMethod15()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int a = 0;
            int b = 2;
            int c = 3;
            int max = o.Max(a, b, c);

            Assert.ThrowsException<Exception>(() => o.Max(a, b, c));
        }
        [TestMethod]
        public void TestMethod16()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int a = 51;
            int b = 2;
            int c = 3;
            int max = o.Max(a, b, c);

            Assert.AreEqual(a, max);
        }
        [TestMethod]
        public void TestMethod17()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int a = 1;
            int b = 0;
            int c = 3;
            int max = o.Max(a, b, c);

            Assert.ThrowsException<Exception>(() => o.Max(a, b, c));
        }
        [TestMethod]
        public void TestMethod18()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int a = 1;
            int b = 51;
            int c = 3;
            int max = o.Max(a, b, c);

            Assert.AreEqual(a, max);
        }
        [TestMethod]
        public void TestMethod19()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int a = 1;
            int b = 2;
            int c = 0;
            int max = o.Max(a, b, c);

            Assert.ThrowsException<Exception>(() => o.Max(a, b, c));
        }
        [TestMethod]
        public void TestMethod20()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int a = 1;
            int b = 2;
            int c = 51;

            Assert.ThrowsException<Exception>(() => o.Max(a, b, c));
        }

    }
}
