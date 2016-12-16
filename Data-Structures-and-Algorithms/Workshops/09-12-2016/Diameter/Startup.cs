using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diameter
{
    public class Startup
    {
        static Dictionary<int, List<Tuple<int, int>>> tree;
        static Dictionary<int, bool> visited;
        static int farthestNode = 0;
        static long farthestNodeTotal = 0;
        static long max = 0;

        public static void Main(string[] args)
        {
            ParseInput();

            int node = tree.First((h) => h.Key > 0).Key;

            FindFarthestNode(node, 0);

            DepthFirstSearch(farthestNode, 0);

            Console.WriteLine(max);
        }

        private static void DepthFirstSearch(int root, long total)
        {
            visited[root] = true;

            foreach (var descendant in tree[root])
            {
                if (!visited[descendant.Item1])
                {
                    DepthFirstSearch(descendant.Item1, total + descendant.Item2);
                }
            }

            visited[root] = false;

            max = total > max ? total : max;
        }

        private static void FindFarthestNode(int node, long total)
        {
            visited[node] = true;

            foreach (var descendant in tree[node])
            {

                if (!visited[descendant.Item1])
                {

                    FindFarthestNode(descendant.Item1, total + descendant.Item2);
                }
            }

            visited[node] = false;

            if (total > farthestNodeTotal)
            {
                farthestNodeTotal = total;
                farthestNode = node;
            }
        }

        private static void ParseInput()
        {
            var nodeCount = int.Parse(Console.ReadLine());

            tree = new Dictionary<int, List<Tuple<int, int>>>(nodeCount);
            visited = new Dictionary<int, bool>(nodeCount);

            for (var i = 0; i < nodeCount - 1; i++)
            {
                var vals = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                var node = new Tuple<int, int>(vals[1], vals[2]);
                var parentOfNode = new Tuple<int, int>(vals[0], vals[2]);

                if (!tree.ContainsKey(parentOfNode.Item1))
                {
                    tree.Add(parentOfNode.Item1, new List<Tuple<int, int>>());
                }

                if (!tree.ContainsKey(node.Item1))
                {
                    tree.Add(node.Item1, new List<Tuple<int, int>>());
                }

                if (!visited.ContainsKey(node.Item1))
                {
                    visited.Add(node.Item1, false);
                }

                if (!visited.ContainsKey(parentOfNode.Item1))
                {
                    visited.Add(parentOfNode.Item1, false);
                }

                tree[parentOfNode.Item1].Add(node);
                tree[node.Item1].Add(parentOfNode);
            }
        }
    }
}
