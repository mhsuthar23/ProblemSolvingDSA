namespace ProblemSolvingDSA.Arrays
{
    internal class _14_EvenSubArrays
    {
        /*
        You are given an integer array A.

        Decide whether it is possible to divide the array into one or more subarrays of even length such that the first and last element of all subarrays will be even.

        Return "YES" if it is possible; otherwise, return "NO" (without quotes).

        Input Format
        The first and the only input argument is an integer array, A.

        Output Format
        Return a string "YES" or "NO" denoting the answer.
        */

        /// <summary>
        /// T.C. = O(1), S.C. = O(1)
        /// </summary>
        public static string Solve(List<int> A)
        {
            int N = A.Count;
            string result;

            if (N % 2 == 0 && A[0] % 2 == 0 && A[N - 1] % 2 == 0)
                result = "YES";
            else
                result = "NO";

            return result;
        }
    }
}
