using ClassLibraryAll;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest13
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data13.csv", "data13#csv", DataAccessMethod.Sequential), DeploymentItem("data13.csv"), TestMethod]

        public void TestMethod1()
        {
            ClassAll cls = new ClassAll();
            float x1 = float.Parse(TestContext.DataRow[0].ToString());
            float y1 = float.Parse(TestContext.DataRow[1].ToString());
            float x2 = float.Parse(TestContext.DataRow[2].ToString());
            float y2 = float.Parse(TestContext.DataRow[3].ToString());
            float x = float.Parse(TestContext.DataRow[4].ToString());
            float y = float.Parse(TestContext.DataRow[5].ToString());
            bool result = bool.Parse(TestContext.DataRow[6].ToString());

            bool result_act = cls.KiemTraDiemHCN(x1, y1, x2, y2, x, y);
            Assert.AreEqual(result, result_act);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]

        public void TestMethodExceptionBai13()
        {
            ClassAll cls = new ClassAll();

            bool result_act = cls.KiemTraDiemHCN(5, 4, 3, 2, 1, 1);
            Assert.AreEqual("exception", result_act);
        }
    }
}
