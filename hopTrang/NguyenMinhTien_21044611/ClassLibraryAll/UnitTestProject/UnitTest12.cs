using ClassLibraryAll;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest12
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data12.csv", "data12#csv", DataAccessMethod.Sequential), DeploymentItem("data12.csv"), TestMethod]

        public void TestMethod1()
        {
            ClassAll cls = new ClassAll();
            float total = float.Parse(TestContext.DataRow[0].ToString());
            float p1 = float.Parse(TestContext.DataRow[1].ToString());
            float p2 = float.Parse(TestContext.DataRow[2].ToString());
            float p3 = float.Parse(TestContext.DataRow[3].ToString());
            float result = float.Parse(TestContext.DataRow[4].ToString());

            float result_act = cls.TinhGiaNhieuMuc(total, p1, p2, p3);
            Assert.AreEqual(result, result_act);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]

        public void TestMethodExceptionBai12()
        {
            ClassAll cls = new ClassAll();

            float result_act = cls.TinhGiaNhieuMuc(-1, 1, 2, 3);
            Assert.AreEqual("exception", result_act);
        }
    }
}
