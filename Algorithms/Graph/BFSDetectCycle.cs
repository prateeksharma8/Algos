using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graph
{


    public class BFSDetectCycle
    {
        public static void Execute()
        {
            int V = 4;
            List<int>[] adj = new List<int>[V];
            for (int i = 0; i < 4; i++)
            {
                adj[i] = new List<int>();
            }

            addEdge(adj, 0, 1);
            addEdge(adj, 1, 2);
            addEdge(adj, 2, 0);
            addEdge(adj, 2, 3);

            if (isCyclicDetected(adj, V))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static void addEdge(List<int>[] adj, int u, int v)
        {
            adj[u].Add(v);
            adj[v].Add(u);
        }

        static bool isCyclicConnected(List<int>[] adj, int s,
                                        int V, bool[] visited)
        {

            // Set parent vertex for every vertex as -1. 
            int[] parent = new int[V];
            for (int i = 0; i < V; i++)
                parent[i] = -1;

            // Create a queue for BFS 
            Queue<int> q = new Queue<int>();

            // Mark the current node as 
            // visited and enqueue it 
            visited[s] = true;
            q.Enqueue(s);

            while (q.Count != 0)
            {

                // Dequeue a vertex from 
                // queue and print it 
                int u = q.Dequeue();

                // Get all adjacent vertices 
                // of the dequeued vertex u. 
                // If a adjacent has not been 
                // visited, then mark it visited 
                // and enqueue it. We also mark parent 
                // so that parent is not considered 
                // for cycle. 
                for (int i = 0; i < adj[u].Count; i++)
                {
                    int v = adj[u][i];
                    if (!visited[v])
                    {
                        visited[v] = true;
                        q.Enqueue(v);
                        parent[v] = u;
                    }
                    else if (parent[u] != v)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        static bool isCyclicDetected(List<int>[] adj, int V)
        {

            // Mark all the vertices as not visited 
            bool[] visited = new bool[V];

            for (int i = 0; i < V; i++)
            {
                if (!visited[i] &&
                    isCyclicConnected(adj, i, V, visited))
                {
                    return true;
                }
            }
            return false;
        }
    }

    // This code is contributed by PrinciRaj1992 


}
