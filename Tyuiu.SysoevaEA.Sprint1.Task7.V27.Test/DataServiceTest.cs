using Tyuiu.SysoevaEA.Sprint1.Task7.V27.Lib;

namespace Tyuiu.SysoevaEA.Sprint1.Task7.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 0.530;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
