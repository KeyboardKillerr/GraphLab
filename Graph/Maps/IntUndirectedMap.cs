﻿using Graph.Maps.Connection;
using Graph.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.Maps
{
    public class IntUndirectedMap : IMap<int>
    {
        private ICollection<Node<int>> _nodes;
        public IntUndirectedMap()
        {
            _nodes = new HashSet<Node<int>>();
        }
        public IntUndirectedMap(int[,] connectionsValues) : this()
        {
            for (int i = 0; i < connectionsValues.GetLength(0); i++)
            {
                for (int j = 0; j < connectionsValues.GetLength(1); j++)
                {
                    if (connectionsValues[i, j] != 0)
                    {
                        AddNode(new Node<int>(i));
                        break;
                    }
                }
            }
            for (int i = 0; i < connectionsValues.GetLength(0) - 1; i++)
            {
                for (int j = i + 1; j < connectionsValues.GetLength(1); j++)
                {
                    if (connectionsValues[i, j] != 0)
                    {
                        ConnectNode(_nodes.First(n => n.Id == i),
                                    _nodes.First(n => n.Id == j),
                                    connectionsValues[i, j]);
                    }
                }
            }
        }
        public ICollection<Node<int>> Nodes { get { return _nodes; } }
        public void AddNode(Node<int> node)
        {
            if (node == null || _nodes.Contains(node)) return;
            _nodes.Add(node);
        }
        public void RemoveNode(Node<int> node)
        {
            if (node == null || !_nodes.Contains(node)) return;
            DisconnectNode(node);
            _nodes.Remove(node);
        }
        public void ConnectNode(Node<int> firstNode, Node<int> secondNode, int val)
        {
            if (firstNode == null || secondNode == null) return;
            else if (!_nodes.Contains(firstNode) || !_nodes.Contains(secondNode)) return;
            firstNode.Join(secondNode);
            secondNode.Join(firstNode);
        }
        public void DisconnectNode(Node<int> node)
        {
            if (node == null || !_nodes.Contains(node)) return;
            foreach (var connectedNode in node.Connections)
            {
                connectedNode.Detach(node);
                node.Detach(connectedNode);
            }
        }
        public Node<int> GetNodeById(int id)
        {
            return _nodes.FirstOrDefault(n => n.Id == id);
        }
        public Node<int> Any()
        {
            return _nodes.FirstOrDefault();
        }
        public void Clear()
        {
            foreach (var node in _nodes) RemoveNode(node);
        }
        public override string ToString()
        {
            string output = "Nodes:\n";
            foreach (var node in _nodes) output += $"{node.Id}\n";
            output += "\nConnections:\n";
            foreach (var node in _nodes)
            {
                foreach (var connectedNode in node.Connections) output += $"{node.Id} {connectedNode.Id}\n";
            }
            return output;
        }
    }
}
