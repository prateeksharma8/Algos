using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{

    public  class DFSCycleDetect
    {
        public class DFSDetectCycle
        {
            int vertices;
            List<List<int>> adjList = new List<List<int>>();

            public DFSDetectCycle(int vertices)
            {
                this.vertices = vertices;
                for (int i = 0; i < vertices; i++)
                {
                    adjList.Add(new List<int>());
                    adjList[i] = new List<int>();
                }
            }
            public void addEgde(int source, int destination)
            {
                adjList[source].Add(destination);
            }
            public bool isCycle()
            {
                bool[] visited = new bool[vertices];
                bool[] recursiveArr = new bool[vertices];

                //do DFS from each node
                for (int i = 0; i < vertices; i++)
                {
                    if (isCycleUtil(i, visited, recursiveArr))
                        return true;
                }
                return false;
            }

            public bool isCycleUtil(int vertex, bool[] visited, bool[] recursiveArr)
            {
                visited[vertex] = true;
                recursiveArr[vertex] = true;

                //recursive call to all the adjacent vertices
                for (int i = 0; i < adjList[vertex].Count; i++)
                {
                    //if not already visited
                    int adjVertex = adjList[vertex][i];
                    if (!visited[adjVertex] && isCycleUtil(adjVertex, visited, recursiveArr))
                    {
                        return true;
                    }
                    else if (recursiveArr[adjVertex])
                        return true;
                }
                //if reached here means cycle has not found in DFS from this vertex
                //reset
                recursiveArr[vertex] = false;
                return false;
            }
        }
        public static void Execute()
        {
            int vertices = 4;
            DFSDetectCycle graph = new DFSDetectCycle(vertices);
            graph.addEgde(0, 1);
            graph.addEgde(1, 2);
            graph.addEgde(2, 3);
            graph.addEgde(3, 1);
            bool result = graph.isCycle();
            Console.WriteLine("is Cycle present: " + result);
        }
    }
}

