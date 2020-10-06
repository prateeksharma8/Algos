using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class AlienDictionary
    {
        public static String findOrder(String[] words)
        {
            if (words == null || words.Length == 0)
                return "";

            // a. Initialize the graph
            Dictionary<char, int> inDegree = new Dictionary<char, int>(); // count of incoming edges for every vertex
            Dictionary<char, List<char>> graph = new Dictionary<char, List<char>>(); // adjacency list graph
            foreach (String word in words)
            {
                foreach (char c in word)
                {
                    if (!inDegree.ContainsKey(c))
                        inDegree.Add(c, 0);

                    if (!graph.ContainsKey(c))
                        graph.Add(c, new List<char>());
                }
            }

            // b. Build the graph
            for (int i = 0; i < words.Length - 1; i++)
            {
                String w1 = words[i], w2 = words[i + 1]; // find ordering of characters from adjacent words
                for (int j = 0; j < Math.Min(w1.Length, w2.Length); j++)
                {
                    char parent = w1[j], child = w2[j];
                    if (parent != child)
                    { // if the two characters are different
                        graph[parent].Add(child); // put the child into it's parent's list
                        inDegree[child] = inDegree[child] + 1; // increment child's inDegree
                        break; // only the first different char between the two words will help us find the order
                    }
                }
            }

            // c. Find all sources i.e., all vertices with 0 in-degrees
            Queue<char> sources = new Queue<char>();
            foreach (KeyValuePair<char, int> entry in inDegree)
            {
                if (entry.Value == 0)
                    sources.Enqueue(entry.Key);
            }

            // d. For each source, Add it to the sortedOrder and subtract one from all of its children's in-degrees
            // if a child's in-degree becomes zero, Add it to the sources queue
            StringBuilder sortedOrder = new StringBuilder();
            while (sources.Count != 0)
            {
                char vertex = sources.Dequeue();
                sortedOrder.Append(vertex);
                List<char> children = graph[vertex]; // get the node's children to decrement their in-degrees
                foreach (char child in children)
                {
                    inDegree[child] = inDegree[child] - 1;
                    if (inDegree[child] == 0)
                        sources.Enqueue(child);
                }
            }

            // if sortedOrder doesn't contain all characters, there is a cyclic dependency between characters, therefore, we
            // will not be able to find the correct ordering of the characters
            if (sortedOrder.Length != inDegree.Count)
                return "";

            return sortedOrder.ToString();
        }

        public static void Execute()
        {
            String result = AlienDictionary.findOrder(new String[] { "ba", "bc", "ac", "cab" });
            Console.WriteLine("char order: " + result);

            result = AlienDictionary.findOrder(new String[] { "cab", "aaa", "aab" });
            Console.WriteLine("char order: " + result);

            result = AlienDictionary.findOrder(new String[] { "ywx", "wz", "xww", "xz", "zyy", "zwz" });
            Console.WriteLine("char order: " + result);
        }
    }
}
