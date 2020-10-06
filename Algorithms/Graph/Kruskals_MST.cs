using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Graph
{
    public class Edge
    {
        public int StartNode { get; set; }
        public int EndNode { get; set; }
        public int Weight { get; set; }
    }



    public static class KruskalAlgorithm
    {
        public static List<Edge> Kruskal(int numberOfVertices, List<Edge> edges)
        {
            // Inital sort
            edges.OrderBy(x=>x.Weight);

            // Set parents table
            var parent = Enumerable.Range(0, numberOfVertices).ToArray();

            // Spanning tree list
            var spanningTree = new List<Edge>();
            foreach (var edge in edges)
            {
                var startNodeRoot = FindRoot(edge.StartNode, parent);
                var endNodeRoot = FindRoot(edge.EndNode, parent);

                if (startNodeRoot != endNodeRoot)
                {
                    // Add edge to the spanning tree
                    spanningTree.Add(edge);

                    // Mark one root as parent of the other
                    parent[endNodeRoot] = startNodeRoot;
                }
            }

            // Return the spanning tree
            return spanningTree;
        }

        private static int FindRoot(int node, int[] parent)
        {
            var root = node;
            while (root != parent[root])
            {
                root = parent[root];
            }

            while (node != root)
            {
                var oldParent = parent[node];
                parent[node] = root;
                node = oldParent;
            }

            return root;
        }
        public static void Execute()
        {
            //all edges
            List<Edge> edges = new List<Edge>();
            edges.Add(new Edge() { StartNode = 1, EndNode = 3, Weight = 5 });
            edges.Add(new Edge() { StartNode = 2, EndNode = 4, Weight = 7 });
            edges.Add(new Edge() { StartNode = 2, EndNode = 1, Weight = 2 });
            edges.Add(new Edge() { StartNode = 3, EndNode = 2, Weight = 3 });
            edges.Add(new Edge() { StartNode = 0, EndNode = 3, Weight = 3 });
            edges.Add(new Edge() { StartNode = 4, EndNode = 0, Weight = 12 });

            //set of vertices
            List<int> vertices = new List<int>() { 0, 1, 2, 3, 4 };

            List<Edge> MinimumSpanningTree = Kruskal(5,edges);

            //printing results
            int totalWeight = 0;
            foreach (Edge edge in MinimumSpanningTree)
            {
                totalWeight += edge.Weight;
                Console.WriteLine("Vertex {0} to Vertex {1} weight is: {2}", edge.StartNode, edge.EndNode, edge.Weight);
            }
            Console.WriteLine("Total Weight: {0}", totalWeight);
            Console.ReadLine();
        }
    }
}
