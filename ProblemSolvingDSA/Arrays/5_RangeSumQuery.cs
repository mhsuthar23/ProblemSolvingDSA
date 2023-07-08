namespace ProblemSolvingDSA.Arrays
{
    internal class _5_RangeSumQuery
    {
        /*
        You are given an integer array A of length N.
        You are also given a 2D integer array B with dimensions M x 2, where each row denotes a [L, R] query.
        For each query, you have to find the sum of all elements from L to R indices in A (0 - indexed).
        More formally, find A[L] + A[L + 1] + A[L + 2] +... + A[R - 1] + A[R] for each query.

        Input Format
        The first argument is the integer array A.
        The second argument is the 2D integer array B.


        Output Format
        Return an integer array of length M where ith element is the answer for ith query in B.
        */

        /// <summary>
        /// T.C. = O(B*A), S.C. = O(B)
        /// </summary>
        public static List<long> Solve(List<int> A, List<List<int>> B)
        {
            List<long> sumList = new List<long>();
            for (int i = 0; i < B.Count; i++)
            {
                List<int> rangeArray = B[i];
                
                int leftRange = rangeArray[0];
                int rightRange = rangeArray[1];

                long sum = 0;
                for (int j = leftRange; j <= rightRange; j++)
                {
                    sum += A[j];
                }

                sumList.Add(sum);
            }

            return sumList;
        }

        /// <summary>
        /// T.C. = O(B+A), S.C. = O(B)
        /// </summary>
        public static List<long> SolveWithPrefixSum(List<int> A, List<List<int>> B)
        {
            List<long> sumList = new List<long>();
            List<long> APrefixSum = new List<long>
            {
                A[0]
            };

            //calculate prefix sum for each element and push to another array same size of A
            for (int i = 1; i < A.Count; i++)
            {
                long prefixSum = APrefixSum[i - 1] + A[i];
                APrefixSum.Add(prefixSum);
            }

            //calculate sum for each item of B
            for (int i = 0; i < B.Count; i++)
            {
                List<int> rangeArray = B[i];

                int leftRange = rangeArray[0];
                int rightRange = rangeArray[1];

                long sum;
                if (leftRange == 0)
                    sum = APrefixSum[rightRange];
                else
                    sum = APrefixSum[rightRange] - APrefixSum[leftRange - 1];

                sumList.Add(sum);
            }

            return sumList;
        }
    }
}
