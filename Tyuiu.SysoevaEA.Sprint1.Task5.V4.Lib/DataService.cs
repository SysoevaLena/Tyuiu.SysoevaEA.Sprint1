using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SysoevaEA.Sprint1.Task5.V4.Lib
{
    public class DataService : ISprint1Task5V4
    {
        public int SecondsToHours(int time)
        {
            decimal hours = time / 3600;
            return (int)Math.Truncate(hours);
        }
    }
}
