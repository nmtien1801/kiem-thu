using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DHKTPM17B_Thong_DuyTien_MinhTien_Thu_Thuan
{
    [TestClass]
    public class UTLab4Exception
    {
        public TestContext TestContext { get; set; }
        private MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\DataUTLab4Exception.csv", "DataUTLab4Exception#csv", DataAccessMethod.Sequential),
            DeploymentItem("DataUTLab4Exception.csv"), TestMethod]

        public void TestMethod1()
        {

            try { 
                String s0 = TestContext.DataRow[0].ToString();
                if (String.IsNullOrWhiteSpace(s0))
                {
                   
                    Assert.Fail($"vui lòng nhập dữ liệu");
                    return;
                }
                if (!long.TryParse(s0, out long s)) {
                    Assert.Fail($"Chỉ nhập số nguyên >= 0: {s0}");
                    return;
                }
                if (s < 0)
                {
                    Assert.Fail($"Giá trị s0 = {s} không hợp lệ. Vui lòng chỉ nhập số nguyên >= 0.");
                    return;
                }


                // Nếu tất cả kiểm tra đều vượt qua, in thông báo s0 hợp lệ.
                Console.WriteLine($"Giá trị s0 hợp lệ: s0 = {s0}");

                long sOutput;
                long actual = o.Sum(s, out sOutput);

                // Đọc giá trị mong đợi cho `expS` và `expK` từ file CSV.
                long expectedS = Convert.ToInt64(TestContext.DataRow[1]?.ToString());
                long expectedK = Convert.ToInt64(TestContext.DataRow[2]?.ToString());

                // Kiểm tra kết quả trả về của `Sum` có khớp với giá trị mong đợi không.
                Assert.AreEqual(expectedK, actual - 1, $"Kết quả không khớp: Giá trị trả về của `Sum` = {actual}.");
                Assert.AreEqual(expectedS, sOutput, $"Kết quả không khớp: Giá trị `s` sau khi tính toán = {sOutput}.");
            }
            catch (Exception e){ Assert.Fail($"exception: {e.Message}"); }
        }
    }
}
