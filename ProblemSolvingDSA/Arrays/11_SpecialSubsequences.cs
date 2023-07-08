namespace ProblemSolvingDSA.Arrays
{
    internal class _11_SpecialSubsequences
    {
        /*
        You have given a string A having Uppercase English letters.
        You have to find how many times subsequence "AG" is there in the given string.

        NOTE: Return the answer modulo 109 + 7 as the answer can be very large.

        Input Format
        First and only argument is a string A.

        Output Format
        Return an integer denoting the answer.
        */

        /// <summary>
        /// T.C. = O(A*A), S.C. = O(1)
        /// </summary>
        public static int Solve(string A)
        {
            int count = 0;
            int M = 1000000007;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 'A')
                {
                    for (int j = i + 1; j < A.Length; j++)
                    {
                        if (A[j] == 'G')
                            count = (count + 1) % M;
                    }
                }
            }

            return count;
        }

        /// <summary>
        /// T.C. = O(A), S.C. = O(A)
        /// </summary>
        public static int SolveWithSuffixSum(string A)
        {
            int result = 0;
            int M = 1000000007;
            int[] ASuffixSum = new int[A.Length];

            if (A[A.Length - 1] == 'G')
                ASuffixSum[A.Length - 1] += 1;

            for (int i = A.Length - 2; i >= 0; i--)
            {
                ASuffixSum[i] = ASuffixSum[i + 1];

                if (A[i] == 'G')
                    ASuffixSum[i] = (ASuffixSum[i] + 1) % M;
                else if (A[i] == 'A')
                    result = (result + ASuffixSum[i + 1]) % M;
            }

            return result;
        }

        /// <summary>
        /// T.C. = O(A), S.C. = O(1)
        /// </summary>
        public static int SolveWithCarryForward(string A)
        {
            int result = 0;
            int M = 1000000007;
            int count = 0;
            int N = A.Length;

            for (int i = N - 1; i >= 0; i--)
            {
                if (A[i] == 'G')
                    count = (count + 1) % M;
                else if (A[i] == 'A')
                    result = (result + count) % M;
            }

            return result;
        }
    }
}
