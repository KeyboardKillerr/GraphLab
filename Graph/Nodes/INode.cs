using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.Nodes
{
    public interface INode<T>
    {
        public T Id { get; init; }
        public ICollection<INode<T>> Connections { get; }
        public void Join(INode<T> node);
        public void Detach(INode<T> node);
    }
}
