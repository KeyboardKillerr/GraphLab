using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Graph.Maps.Connection;
using Graph.Nodes;

namespace Graph.Maps
{
    internal interface IMap<T>
    {
        public ICollection<Node<T>> Nodes { get; }
        public void AddNode(Node<T> node);
        public void RemoveNode(Node<T> node);
        public void ConnectNode(Node<T> firstNode, Node<T> secondNode, int val);
        public void DisconnectNode(Node<T> node);
        public Node<T> GetNodeById(T id);
        public Node<T> Any();
        public void Clear();
        public string ToString();
    }
}
