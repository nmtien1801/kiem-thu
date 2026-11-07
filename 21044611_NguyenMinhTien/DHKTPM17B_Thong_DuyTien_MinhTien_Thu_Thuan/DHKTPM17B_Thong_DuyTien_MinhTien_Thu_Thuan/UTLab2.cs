using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DHKTPM17B_Thong_DuyTien_MinhTien_Thu_Thuan
{
    [TestClass]
    public class UTLab2
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int a = 0;
            int b = 0;
            int c = 0;
            float x1 = float.NaN;
            float x2 = float.NaN;
            string act = o.SolveQuadratic(a, b, c, out x1, out x2);
            string exp = "Vô số nghiệm";
            Assert.AreEqual(exp, act);
        }
        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int a = 5;
            int b = -2;
            int c = 1;
            float x1 = float.NaN;
            float x2 = float.NaN;
            string act = o.SolveQuadratic(a, b, c, out x1, out x2);
            string exp = "Vô nghiệm";
            Assert.AreEqual(exp, act);
        }
        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int a = 1;
            int b = -1;
            int c = -6;
            float x1 = 3;
            float x2 = -2;
            string act = o.SolveQuadratic(a, b, c, out x1, out x2);
            string exp = "Có 2 nghiệm phân biệt";
            Assert.AreEqual(exp, act);
        }
        [TestMethod]
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int a = 2;
            int b = 4;
            int c = 2;
            float x1 = -1;
            float x2 = -1;
            string act = o.SolveQuadratic(a, b, c, out x1, out x2);
            string exp = "Có nghiệm kép";
            Assert.AreEqual(exp, act);
        }
        [TestMethod]
        public void TestMethod5()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int a = 0;
            int b = 1;
            int c = 2;
            float x1 = -2;
            float x2 = -2;
            string act = o.SolveQuadratic(a, b, c, out x1, out x2);
            string exp = "Có 1 nghiệm";
            Assert.AreEqual(exp, act);
        }

    }
}
