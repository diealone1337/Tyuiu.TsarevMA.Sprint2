using Tyuiu.TsarevMA.Sprint2.Task6.V15.Lib;
namespace Tyuiu.TsarevMA.Sprint2.Task6.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();
            int k = 1;

            string res = ds.FindDayName(k);
            string wait = "понедельник";

            Assert.AreEqual(wait, res);
        }
    }
}
