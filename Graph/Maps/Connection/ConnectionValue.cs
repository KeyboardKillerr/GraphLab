using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.Maps.Connection
{
    public struct ConnectionValue<T>
    {
        public T FirstIndex;
        public T SecondIndex;
        public int Value;
    }
}
