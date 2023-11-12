using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.YagodinVA.Sprint4.Task7.V17.Lib
{
    public class DataService : ISprint4Task7V17
    {
        public int Calculate(int n, int m, string value)
        {
            int res = 0;
            foreach (char element in value)
            {
                if ((int)Char.GetNumericValue(element) % 2 == 0)
                {
                    res += 1;
                }
            }
            return res;
        }
    }
}
