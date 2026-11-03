using Tyuiu.TsarevMA.Sprint2.Task4.V19.Lib;
namespace Tyuiu.TsarevMA.Sprint2.Task4.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 6.04;

            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 0.97;

            Assert.AreEqual(wait, res);
        }
    }
}
