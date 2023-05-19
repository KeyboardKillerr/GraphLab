using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.Identifier
{
    internal interface IIdentifier<T>
    {
        public T GetIndex();
        public T SetIndex(T index);
    }
}
