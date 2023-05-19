using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.Identifier
{
    internal class IntIdentifier : IIdentifier<int>
    {
        public int GetIndex() { return default; }
        public int SetIndex(int index) { return index; }
    }
}
