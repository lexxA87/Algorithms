namespace Algoritms
{
    public class LongestCommonSubsequence
    {

        private static int MAX(int a, int b)
        {
            return a > b ? a : b;
        }
        public static int[,] ComputeLCSTable(string X, string Y)
        {
            var l = new int[X.Length + 1, Y.Length + 1];

            for (int i = 1; i <= X.Length; ++i)
            {
                for (int j = 1; j <= Y.Length; ++j)
                {
                    if (X[i - 1] == Y[j - 1])
                    {
                        l[i, j] = l[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        l[i, j] = MAX(l[i, j - 1], l[i - 1, j]);
                    }
                }
            }
            return l;
        }

        public static string AssembleLCS(string X, string Y, int[,] l, int i, int j)
        {
            if (j == 0 || i == 0) return "";
            else if (X[i - 1] == Y[j - 1]) return AssembleLCS(X, Y, l, i - 1, j - 1) + X[i - 1];
            else return l[i, j - 1] > l[i - 1, j] ? AssembleLCS(X, Y, l, i, j - 1) : AssembleLCS(X, Y, l, i - 1, j);
        }
    }
}
