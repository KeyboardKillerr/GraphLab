using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.Identifier
{
    internal class IndexManager<T>
    {
        public object Id { get; init; }
        public IndexManager()
        {
            switch (Type.GetTypeCode(typeof(T)))
            {
                case TypeCode.Int32:
                    Id = new IntIdentifier();
                    return;
                case TypeCode.String:
                    return;
                case TypeCode.Object:
                    return;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
