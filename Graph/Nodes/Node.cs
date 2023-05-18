using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Graph.Nodes
{
    public class Node<T> : INode<T>
    {
        private ICollection<INode<T>> _connections;
        public T Id { get; init; }
        public ICollection<INode<T>> Connections { get { return _connections; } }
        public Node()
        {
            Id = default(T);
            _connections = new HashSet<INode<T>>();
        }
        public Node(T id)
        {
            Id = id;
            _connections = new HashSet<INode<T>>();
        }
        public void Join(INode<T> node)
        {
            if (node != null && node != this && !_connections.Contains(node)) _connections.Add(node);
        }
        public void Detach(INode<T> node)
        {
            if (node != null && node != this && _connections.Contains(node)) _connections.Remove(node);
        }
    }
}
