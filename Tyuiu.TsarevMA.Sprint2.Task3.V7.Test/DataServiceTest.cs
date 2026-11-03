using Tyuiu.TsarevMA.Sprint2.Task3.V7.Lib;
namespace Tyuiu.TsarevMA.Sprint2.Task3.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 50;

            Assert.AreEqual(wait, res);
        }
    }
}
