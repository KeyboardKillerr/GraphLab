using System;
using System.Data;
using Graph.Maps;
using Graph.Algos;

namespace ConsoleDebuger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] graph = new int[4, 4]{ { 0, 5, 0, 0},
                                          { 5, 0, 0, 2},
                                          { 0, 0, 0, 0},
                                          { 0, 2, 0, 0} };
            IntUndirectedMap map = new IntUndirectedMap(graph);
            Console.WriteLine(map.ToString());
            map.Clear();
            Console.WriteLine(map.ToString());
        }
    }
}
