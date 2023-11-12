using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.YagodinVA.Sprint4.Task6.V21.Lib
{
    public class DataService : ISprint4Task6V21
    {
        public int Calculate(string[] array)
        {
            int res = 0;
            foreach (string element in array)
            {
                if (element.Length < 8)
                {
                    res += 1;
                }
            }
            return res;
        }
    }
}
