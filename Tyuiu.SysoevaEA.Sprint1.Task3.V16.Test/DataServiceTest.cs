using Tyuiu.SysoevaEA.Sprint1.Task3.V16.Lib;

namespace Tyuiu.SysoevaEA.Sprint1.Task3.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5.875;
            double y = 5.225;
            var res = ds.CoeffOfQuadraticEquation(x, y);
            double wait = -x - y;
            Assert.AreEqual(wait, res);
        }
    }
}
