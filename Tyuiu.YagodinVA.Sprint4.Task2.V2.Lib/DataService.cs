using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.YagodinVA.Sprint4.Task2.V2.Lib
{
    public class DataService : ISprint4Task2V2
    {
        public int Calculate(int[] array)
        {
            int res = 1;
            foreach (int number in array)
            {
                if (number % 2 == 1)
                {
                    res *= number;
                }
            }
            return res;
        }
    }
}
