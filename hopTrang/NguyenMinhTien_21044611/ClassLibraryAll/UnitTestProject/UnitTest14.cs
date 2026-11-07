using ClassLibraryAll;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest14
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data14.csv", "data14#csv", DataAccessMethod.Sequential), DeploymentItem("data14.csv"), TestMethod]

        public void TestMethod1()
        {
            ClassAll cls = new ClassAll();
            float w = float.Parse(TestContext.DataRow[0].ToString());
            float h = float.Parse(TestContext.DataRow[1].ToString());
            float x = float.Parse(TestContext.DataRow[2].ToString());
            float y = float.Parse(TestContext.DataRow[3].ToString());
            float s = float.Parse(TestContext.DataRow[4].ToString());

            var result = cls.TaoIcon(w, h);

            Assert.AreEqual(x, (float)result.x);
            Assert.AreEqual(y, (float)result.y);
            Assert.AreEqual(s, (float)result.s);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]

        public void TestMethodExceptionBai14()
        {
            ClassAll cls = new ClassAll();

            var result = cls.TaoIcon(-1, -0);
            Assert.AreEqual("error", result.x);
            Assert.AreEqual("error", result.y);
            Assert.AreEqual("error", result.s);
        }
    }
}
