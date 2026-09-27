using Tyuiu.SysoevaEA.Sprint1.Task5.V4.Lib;

namespace Tyuiu.SysoevaEA.Sprint1.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 13257;
            int wait = 3;
            var res = ds.SecondsToHours(k);
            Assert.AreEqual(wait, res);
        }
    }
}
