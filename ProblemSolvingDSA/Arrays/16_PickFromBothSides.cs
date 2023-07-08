namespace ProblemSolvingDSA.Arrays
{
    internal class _16_PickFromBothSides
    {
        /*
        You are given an integer array A of size N.
        You have to perform B operations. In one operation, you can remove either the leftmost or the rightmost element of the array A.

        Find and return the maximum possible sum of the B elements that were removed after the B operations.

        NOTE: Suppose B = 3, and array A contains 10 elements, then you can:

        Remove 3 elements from front and 0 elements from the back, OR
        Remove 2 elements from front and 1 element from the back, OR
        Remove 1 element from front and 2 elements from the back, OR
        Remove 0 elements from front and 3 elements from the back.

        Input Format
        First argument is an integer array A.
        Second argument is an integer B.

        Output Format
        Return an integer denoting the maximum possible sum of elements you removed.
        */

        /// <summary>
        /// T.C. = O(A), S.C. = O(A)
        /// </summary>
        public static int Solve(List<int> A, int B)
        {
            int N = A.Count;
            int maxSum;
            int[] APrefixSum = new int[N];
            int[] ASuffixSum = new int[N];

            APrefixSum[0] = A[0];
            ASuffixSum[N - 1] = A[N - 1];

            for (int i = 1; i < N; i++)
            {
                int sum = APrefixSum[i - 1] + A[i];
                APrefixSum[i] = sum;
            }

            for (int i = N - 2; i >= 0; i--)
            {
                int sum = ASuffixSum[i + 1] + A[i];
                ASuffixSum[i] = sum;
            }

            maxSum = APrefixSum[B - 1];

            if (ASuffixSum[N - B] > maxSum)
                maxSum = ASuffixSum[N - B];

            for (int i = 1; i < B; i++)
            {
                int sum = APrefixSum[i - 1] + ASuffixSum[N - (B - i)];

                if (sum > maxSum)
                    maxSum = sum;
            }

            return maxSum;
        }

        /// <summary>
        /// T.C. = O(A), S.C. = O(1) - by changing input space
        /// </summary>
        public static int SolveWithCarryForward(List<int> A, int B)
        {
            int N = A.Count;
            int maxSum;

            for (int i = 1; i < N; i++)
            {
                int sum = A[i - 1] + A[i];
                A[i] = sum;
            }

            maxSum = A[B - 1];

            if (N == B)
                return maxSum;

            if ((A[N - 1] - A[N - B - 1]) > maxSum)
                maxSum = A[N-1] - A[N - B -1];

            for (int i = 1; i < B; i++)
            {
                int leftSum = A[i - 1];
                int rightSum = A[N - 1] - A[N - (B - i) - 1];
                int sum = leftSum + rightSum;

                if (sum > maxSum)
                    maxSum = sum;
            }

            return maxSum;
        }
    }
}
