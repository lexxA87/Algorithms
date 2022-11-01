namespace Algoritms
{
    public class TopologicalSort
    {
        public static List<int> Sort(int[][] graph)
        {
            // 1,2
            int[] inDegree = new int[graph.Length];
            List<int> list = new();

            // 3
            for (int i = 0; i < graph.Length; i++)
            {
                for (int j = 0; j < graph[i].Length; j++)
                {
                    var k = graph[i][j];
                    inDegree[k]++;
                }
            }

            // 4
            var next = new Stack<int>();
            for (int i = 0; i < inDegree.Length; i++)
            {
                if (inDegree[i] == 0) next.Push(i);
            }

            // 5
            while (next.Count > 0)
            {
                int u = next.Pop();
                list.Add(u);
                for (int i = 0; i < graph[u].Length; i++)
                {
                    var v = graph[u][i];
                    inDegree[v]--;
                    if (inDegree[v] == 0) next.Push(v);
                }
            }

            return list;
        }

    }
}
