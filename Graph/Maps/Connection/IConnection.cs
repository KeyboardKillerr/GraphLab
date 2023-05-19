using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.Maps.Connection
{
    internal interface IConnection<T>
    {
        public ICollection<ConnectionValue<T>> Connections { get; }
        public ConnectionValue<T> GetConnectionValue(T firstId, T secondId);
    }
}
