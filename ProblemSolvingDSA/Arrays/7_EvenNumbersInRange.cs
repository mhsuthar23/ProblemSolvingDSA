namespace ProblemSolvingDSA.Arrays
{
    internal class _7_EvenNumbersInRange
    {
        /*
        You are given an array A of length N and Q queries given by the 2D array B of size Q×2.
        Each query consists of two integers B[i][0] and B[i][1].
        For every query, your task is to find the count of even numbers in the range from A[B[i][0]] to A[B[i][1]].

        Input Format
        First argument A is an array of integers.
        Second argument B is a 2D array of integers.

        Output Format
        Return an array of integers.
         */

        /// <summary>
        /// T.C. = O(B*A), S.C. = O(B)
        /// </summary>
        public static List<int> Solve(List<int> A, List<List<int>> B)
        {
            List<int> AEven = new List<int>();

            for (int i = 0; i < B.Count; i++)
            {
                int left = B[i][0];
                int right = B[i][1];

                int count = 0;
                for (int j = left; j <= right; j++)
                {
                    if (A[j] % 2 == 0)
                        count++;
                }

                AEven.Add(count);
            }

            return AEven;
        }

        /// <summary>
        /// T.C. = O(A+B), S.C. = O(A+B)
        /// </summary>
        public static List<int> SolveWithPrefixSum(List<int> A, List<List<int>> B)
        {
            List<int> AEven = new List<int>();
            List<int> APrefixSum = new List<int>()
            {
                A[0] % 2 == 0 ? 1: 0
            };

            for (int i = 1; i < A.Count; i++)
            {
                int count = A[i] % 2 == 0 ? 1 : 0;
                int sum = APrefixSum[i - 1] + count;
                APrefixSum.Add(sum);
            }

            for (int i = 0; i < B.Count; i++)
            {
                int left = B[i][0];
                int right = B[i][1];

                int count;
                if (left == 0)
                    count = APrefixSum[right];
                else
                    count = APrefixSum[right] - APrefixSum[left - 1];

                AEven.Add(count);
            }

            return AEven;
        }
    }
}
