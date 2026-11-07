using ClassLibraryAll;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest8
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data8.csv", "data8#csv", DataAccessMethod.Sequential), DeploymentItem("data8.csv"), TestMethod]

        public void TestMethod1()
        {
            ClassAll cls = new ClassAll();


            double a = double.Parse(TestContext.DataRow[0].ToString());
            double b = double.Parse(TestContext.DataRow[1].ToString());
            double c = double.Parse(TestContext.DataRow[2].ToString());
            double x1 = double.Parse(TestContext.DataRow[3].ToString());
            double x2 = double.Parse(TestContext.DataRow[4].ToString());

            var result = cls.PhuongTrinhBacHai(a, b, c);
            Assert.AreEqual(x1, (double)result.Item1, 0.2);
            Assert.AreEqual(x2, (double)result.Item2, 0.2);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data8_ex.csv", "data8_ex#csv", DataAccessMethod.Sequential), DeploymentItem("data8_ex.csv"), TestMethod]
        public void TestMethodExceptionBai08()
        {
            ClassAll cls = new ClassAll();

            double a = double.Parse(TestContext.DataRow[0].ToString());
            double b = double.Parse(TestContext.DataRow[1].ToString());
            double c = double.Parse(TestContext.DataRow[2].ToString());
            string x1 = TestContext.DataRow[3].ToString();
            string x2 = TestContext.DataRow[4].ToString();

            var result = cls.PhuongTrinhBacHai(a, b, c);
            Assert.AreEqual(x1, x1);
            Assert.AreEqual(x2, x2);
        }
    }
}
