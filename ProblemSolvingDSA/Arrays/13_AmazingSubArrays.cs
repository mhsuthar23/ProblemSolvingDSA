namespace ProblemSolvingDSA.Arrays
{
    internal class _13_AmazingSubArrays
    {
        /*
         You are given a string S, and you have to find all the amazing substrings of S.
        An amazing Substring is one that starts with a vowel (a, e, i, o, u, A, E, I, O, U).

        Input
        Only argument given is string S.

        Output
        Return a single integer X mod 10003, here X is the number of Amazing Substrings in given the string.
        */

        /// <summary>
        /// T.C. = O(A*A), S.C. = O(1)
        /// </summary>
        public static int Solve(string A)
        {
            int count = 0;
            int M = 10003;
            int N = A.Length;

            for (int i = 0; i < N; i++)
            {
                for (int j = i; j < N; j++)
                {
                    if (IsVowel(A[i]))
                        count = (count + 1) % M;
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
            int M = 10003;
            int N = A.Length;
            int[] ASuffixSum = new int[A.Length];

            ASuffixSum[N - 1] = 1;
            if (IsVowel(A[N-1]))
                result = (result + ASuffixSum[N-1]) % M;

            for (int i = N-2; i >=0; i--)
            {
                ASuffixSum[i] = (ASuffixSum[i + 1] + 1) % M;

                if (IsVowel(A[i]))
                    result = (result + ASuffixSum[i]) % M;
            }

            return result;
        }

        /// <summary>
        /// T.C. = O(A), S.C. = O(1)
        /// </summary>
        public static int SolveWithCarryForward(string A)
        {
            int result = 0;
            int count = 0;
            int M = 10003;
            int N = A.Length;

            for (int i = N - 1; i >= 0; i--)
            {
                count = (count + 1) % M;

                if (IsVowel(A[i]))
                    result = (result + count) % M;
            }

            return result;
        }

        private static bool IsVowel(char c)
        {
            return c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U'
                    || c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
        }
    }
}
