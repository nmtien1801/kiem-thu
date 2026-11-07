using ClassLibraryAll;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest11
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data11.csv", "data11#csv", DataAccessMethod.Sequential), DeploymentItem("data11.csv"), TestMethod]

        public void TestMethod1()
        {
            ClassAll cls = new ClassAll();
            float w = float.Parse(TestContext.DataRow[0].ToString());
            float h = float.Parse(TestContext.DataRow[1].ToString());
            float ww = float.Parse(TestContext.DataRow[2].ToString());
            float wh = float.Parse(TestContext.DataRow[3].ToString());
            float x = float.Parse(TestContext.DataRow[4].ToString());
            float y = float.Parse(TestContext.DataRow[5].ToString());

            var result = cls.CanGiuaAnh(w, h, ww, wh);
            Assert.AreEqual(x, result.Item1);
            Assert.AreEqual(y, result.Item2);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]

        public void TestMethodExceptionBai11()
        {
            ClassAll cls = new ClassAll();

            var result = cls.CanGiuaAnh(0, 1, 1, 1);
            Assert.AreEqual("exception", result.Item1);
            Assert.AreEqual("exception", result.Item2);
        }
    }
}
