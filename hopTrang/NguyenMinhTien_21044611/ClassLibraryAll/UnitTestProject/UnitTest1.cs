using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibraryAll;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV","|DataDirectory|\\data1.csv","data1#csv",
            DataAccessMethod.Sequential),
            DeploymentItem("data1.csv"), TestMethod]
        public void TestMethod1()
        {
            ClassAll classAll = new ClassAll();
            int firstRadius = int.Parse(TestContext.DataRow[0].ToString());
            int secRadius = int.Parse(TestContext.DataRow[1].ToString());
            int distance = int.Parse(TestContext.DataRow[2].ToString());

            try
            {
                int exp = int.Parse(TestContext.DataRow[3].ToString());

                int act = classAll.GetPositionOf2Cir(firstRadius, secRadius, distance);
                Assert.AreEqual(exp, act);
            }
            catch (Exception ex)
            {
                Assert.ThrowsException<IndexOutOfRangeException>(() => classAll.GetPositionOf2Cir(firstRadius, secRadius, distance));

            }
        }
    }
}
