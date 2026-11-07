using ClassLibraryAll;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest18
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data18.csv", "data18#csv", DataAccessMethod.Sequential), DeploymentItem("data18.csv"), TestMethod]

        public void TestMethod1()
        {
            ClassAll cls = new ClassAll();

            String email = TestContext.DataRow[0].ToString();

            bool result = bool.Parse(TestContext.DataRow[1].ToString());

            bool result_act = cls.KiemTraEmail(email);
            Assert.AreEqual(result, result_act);
        }
    }
}
