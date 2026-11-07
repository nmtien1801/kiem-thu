using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibraryAll;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest9
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data9.csv", "data9#csv", DataAccessMethod.Sequential), DeploymentItem("data9.csv"), TestMethod]

        public void TestMethod1()
        {
            ClassAll cls = new ClassAll();
            float a = float.Parse(TestContext.DataRow[0].ToString());
            float b = float.Parse(TestContext.DataRow[1].ToString());
            float x = float.Parse(TestContext.DataRow[2].ToString());

            float result = float.Parse(TestContext.DataRow[3].ToString());

            float result_act = cls.Limit(a, b, x);
            Assert.AreEqual(result, result_act);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestBai09_Exception()
        {
            ClassAll cls = new ClassAll();

            float result_act = cls.Limit(4, 2, 2);
            Assert.AreEqual("excption", result_act);
        }
    }
}
