using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Calculator<T>
    {
       

        public T Add(T x1,T y1)
        {
            dynamic x = x1;
            dynamic y = y1;
            return x + y;
        }
        public T Sub(T x1,T y1)
        {
            dynamic x = x1;
            dynamic y = y1;
            return x - y;

        }
        public T Mul(T x1, T y1)
        {
            dynamic x = x1;
            dynamic y = y1;
            return x * y;
        }
        public T Div(T x1, T y1)
        {
            dynamic x = x1;
            dynamic y = y1;

            if (y != 0)
            {
                return x / y;
            }
            else
            {
                return y;
            }
        }
    }
}
