using ClassLibraryAll;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest16
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data16.csv", "data16#csv", DataAccessMethod.Sequential), DeploymentItem("data16.csv"), TestMethod]

        public void TestMethod1()
        {
            ClassAll cls = new ClassAll();

            String pass = TestContext.DataRow[0].ToString();

            bool result = bool.Parse(TestContext.DataRow[1].ToString());

            bool result_act = cls.KiemTraPassWord(pass);
            Assert.AreEqual(result, result_act);
        }
    }
}
