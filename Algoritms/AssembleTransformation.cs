namespace Algoritms
{
    public class AssembleTransformation
    {

        public static int[,] ComputeTransformTableCost(string X, string Y, int costCopy, int costRep, int costDel, int costIns)
        {
            var cost = new int[X.Length + 1, Y.Length + 1];

            for (int i = 1; i <= X.Length; i++)
            {
                cost[i, 0] = i * costDel;
            }

            for (int j = 1; j <= Y.Length; j++)
            {
                cost[0, j] = j * costIns;
            }

            for (int i = 1; i <= X.Length; i++)
            {
                for (int j = 1; j <= Y.Length; j++)
                {
                    // i
                    if (X[i - 1] == Y[j - 1]) cost[i, j] = cost[i - 1, j - 1] + costCopy;
                    else cost[i, j] = cost[i - 1, j - 1] + costRep;

                    // ii
                    if (cost[i - 1, j] + costDel < cost[i, j]) cost[i, j] = cost[i - 1, j] + costDel;

                    /// iii
                    if (cost[i, j - 1] + costIns < cost[i, j]) cost[i, j] = cost[i, j - 1] + costIns;
                }
            }

            return cost;
        }

        public static string[,] ComputeTransformTableOperation(string X, string Y, int costCopy, int costRep, int costDel, int costIns)
        {
            var cost = new int[X.Length + 1, Y.Length + 1];
            var operations = new string[X.Length + 1, Y.Length + 1];

            for (int i = 1; i <= X.Length; i++)
            {
                cost[i, 0] = i * costDel;
                operations[i, 0] = "del";
            }

            for (int j = 1; j <= Y.Length; j++)
            {
                cost[0, j] = j * costIns;
                operations[0, j] = "ins";
            }

            for (int i = 1; i <= X.Length; i++)
            {
                for (int j = 1; j <= Y.Length; j++)
                {
                    // i
                    if (X[i - 1] == Y[j - 1])
                    {
                        cost[i, j] = cost[i - 1, j - 1] + costCopy;
                        operations[i, j] = "copy";
                    }
                    else
                    {
                        cost[i, j] = cost[i - 1, j - 1] + costRep;
                        operations[i, j] = "rep";
                    }

                    // ii
                    if (cost[i - 1, j] + costDel < cost[i, j])
                    {
                        cost[i, j] = cost[i - 1, j] + costDel;
                        operations[i, j] = "del";
                    }

                    /// iii
                    if (cost[i, j - 1] + costIns < cost[i, j])
                    {
                        cost[i, j] = cost[i, j - 1] + costIns;
                        operations[i, j] = "ins";
                    }
                }
            }

            return operations;
        }

        public static string Transform(string[,] operations, int i, int j)
        {
            if (i == 0 && j == 0) return "";
            else if (operations[i, j] == "copy" || operations[i, j] == "rep")
            {
                return Transform(operations, i - 1, j - 1) + " " + operations[i, j];
            }
            else if (operations[i, j] == "del")
            {
                return Transform(operations, i - 1, j) + " " + operations[i, j];
            }
            else return Transform(operations, i, j - 1) + " " + operations[i, j];
        }
    }
}
