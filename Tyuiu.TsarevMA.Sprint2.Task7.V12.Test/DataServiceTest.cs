using Tyuiu.TsarevMA.Sprint2.Task7.V12.Lib;
namespace Tyuiu.TsarevMA.Sprint2.Task7.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 1.5;
            double y = 0.2;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
