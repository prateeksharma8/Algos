using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Backtracking
{
    public class Pair<X, Y>
    {
        public X first;
        public Y second;
        public Pair(X first, Y second)
        {
            this.first = first;
            this.second = second;
        }
    }
    public class IntPair : Pair<int, int>
    {
        public IntPair(int first, int second) : base(first, second)
        {

        }
    }

    public class Boggle
    {
        // code assumes that both dimensions of grid are same
        char[,] grid;
        HashSet<String> dictionary = new HashSet<string>();
        bool[,] state;

        List<IntPair> find_all_nbrs(int x, int y)
        {

            List<IntPair> nbrs = new List<IntPair>();

            int startX = Math.Max(0, x - 1);
            int startY = Math.Max(0, y - 1);
            int endX = Math.Min(grid.GetLength(0) - 1, x + 1);
            int endY = Math.Min(grid.GetLength(1) - 1, y + 1);

            for (int i = startX; i <= endX; ++i)
            {
                for (int j = startY; j <= endY; ++j)
                {
                    if (state[i, j])
                    {
                        continue;
                    }
                    nbrs.Add(new IntPair(i, j));
                }
            }
            return nbrs;
        }

        void findWordsRec(int i, int j, StringBuilder current, HashSet<String> words)
        {

            if (current.Length > 0 &&
                dictionary.Contains(current.ToString()))
            {
                words.Add(current.ToString());
            }

            // we can really speed up our algorithm if 
            // we have prefix method available
            // for our dictionary by using code like below
            /*
            if (!dictionary.is_prefix(current)) {
              // if current word is not prefix of any word in dictionary
              // we don't need to continue with search
              return;
            }
            */

            List<IntPair> nbrs = find_all_nbrs(i, j);
            foreach (IntPair pr in nbrs)
            {
                current.Append(grid[pr.first,pr.second].ToString());
                state[pr.first, pr.second] = true;
                findWordsRec(pr.first, pr.second, current, words);
                current.Length = current.Length - 1;
                state[pr.first, pr.second] = false;
            }
        }

        Boggle(char[,] grid, HashSet<String> dictionary)
        {
            this.grid = grid;
            this.dictionary = dictionary;
            this.state = new bool[grid.GetLength(0), grid.GetLength(1)];

            for (int i = 0; i < grid.GetLength(0); ++i)
            {
                for (int j = 0; j < grid.GetLength(1); ++j)
                {
                    state[i, j] = false;
                }
            }
        }

        public HashSet<String> findAllWords()
        {
            HashSet<String> words = new HashSet<String>();
            StringBuilder currentWord = new StringBuilder();
            for (int i = 0; i < grid.Length; ++i)
            {
                for (int j = 0; j < grid.Length; ++j)
                {
                    findWordsRec(i, j, currentWord, words);
                }
            }

            return words;
        }

        public static void Execute()
        {
            char[,] grid = new char[,] {
      {'c', 'a', 't'},
      {'r', 'r', 'e'},
      {'t', 'o', 'n'}
    };

            String[] dict = { "cat", "cater", "cartoon", "art", "toon", "moon", "eat", "ton" };
            HashSet<String> dictionary = new HashSet<String>();
            foreach (String s in dict)
            {
                dictionary.Add(s);
            }

            Boggle b = new Boggle(grid, dictionary);
            HashSet<String> words = b.findAllWords();
            foreach (String s in words)
            {
                Console.WriteLine(s);
            }
        }
    }
}
