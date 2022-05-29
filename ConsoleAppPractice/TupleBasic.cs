using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPractice
{
    public class TupleBasic
    {
        static public (int max,int min) GetMaxMin(int x,int y)
        {
            return x >= y ? (x, y) : (y, x);
        }
    }
}
