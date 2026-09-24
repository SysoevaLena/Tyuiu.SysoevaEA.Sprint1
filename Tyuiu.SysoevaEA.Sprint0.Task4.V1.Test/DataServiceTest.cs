using Tyuiu.SysoevaEA.Sprint0.Task4.V1.Lib;

namespace Tyuiu.SysoevaEA.Sprint0.Task4.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double wait = 0.111;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
