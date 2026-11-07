using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DHKTPM17B_Thong_DuyTien_MinhTien_Thu_Thuan
{
    [TestClass]
    public class UTLab3
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\DataUTLab3.csv", "DataUTLab3#csv", DataAccessMethod.Sequential),
            DeploymentItem("DataUTLab3.csv"), TestMethod]

        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int chiSoMoi = Convert.ToInt32(TestContext.DataRow["chiSoMoi"]);
            int chiSoCu = Convert.ToInt32(TestContext.DataRow["chiSoCu"]);
            double expectedResult = Convert.ToDouble(TestContext.DataRow["expectedResult"]);

            double result = methodLibrary.TinhTienDien(chiSoMoi, chiSoCu);
            Console.WriteLine(result);

            Assert.AreEqual(expectedResult, result);
        }

    }
}
