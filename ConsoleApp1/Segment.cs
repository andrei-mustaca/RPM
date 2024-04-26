using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Segment<T>
    {
        private T x1;
        public T X1 { set; get; }
        private T y1;
        public T Y1 { set; get; }
        private T x2;
        public T X2 { set; get; }
        private T y2;
        public T Y2 { set; get; }
    }
}
