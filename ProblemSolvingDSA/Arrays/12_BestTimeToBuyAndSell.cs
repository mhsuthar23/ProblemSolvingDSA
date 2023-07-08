namespace ProblemSolvingDSA.Arrays
{
    internal class _12_BestTimeToBuyAndSell
    {
        /*
        Say you have an array, A, for which the ith element is the price of a given stock on day i.
        If you were only permitted to complete at most one transaction (ie, buy one and sell one share of the stock), design an algorithm to find the maximum profit.

        Return the maximum possible profit.

        Input Format
        The first and the only argument is an array of integers, A.


        Output Format
        Return an integer, representing the maximum possible profit.
        */

        /// <summary>
        /// T.C. = O(A), S.C. = O(A)
        /// </summary>
        public static int SolveWithPrefixSum(List<int> A)
        {
            int maxProfit = 0;
            int N = A.Count;
            if (N == 0)
                return 0;

            int[] AMax = new int[N];

            AMax[N - 1] = A[N - 1];

            for (int i = N - 2; i >= 0; i--)
            {
                AMax[i] = AMax[i + 1] > A[i] ? AMax[i + 1] : A[i];
            }

            for (int i = 0; i < N; i++)
            {
                int profit = AMax[i] - A[i];
                if (profit > maxProfit)
                    maxProfit = profit;
            }

            return maxProfit;
        }

        /// <summary>
        /// T.C. = O(A), S.C. = O(1)
        /// </summary>
        public static int SolveWithCarryForward(List<int> A)
        {
            int maxProfit = 0;
            int N = A.Count;
            if (N == 0)
                return 0;

            int max = A[N - 1];

            for (int i = N - 2; i >= 0; i--)
            {
                if (A[i] > max)
                    max = A[i];

                int profit = max - A[i];

                if(maxProfit < profit)
                    maxProfit = profit;
            }
            
            return maxProfit;
        }
    }
}
