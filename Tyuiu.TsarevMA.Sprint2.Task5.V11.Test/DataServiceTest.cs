using Tyuiu.TsarevMA.Sprint2.Task5.V11.Lib;
namespace Tyuiu.TsarevMA.Sprint2.Task5.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void FindDateOfNextDay1()
        {
            DataService ds = new DataService();
            int g = 2026;
            int m = 1;
            int n = 31;

            string res = ds.FindDateOfNextDay(g, m, n);
            string wait = "01.02.2026";

            Assert.AreEqual(wait, res);
        }
    }
}
