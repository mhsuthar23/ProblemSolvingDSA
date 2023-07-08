namespace ProblemSolvingDSA.Arrays
{
    internal class _10_ClosestMinMax
    {
        /*
         Given an array A, find the size of the smallest subarray such that it contains at least one occurrence of the maximum value of the array
        and at least one occurrence of the minimum value of the array.

        Input Format
        First and only argument is vector A

        Output Format
        Return the length of the smallest subarray which has at least one occurrence of minimum and maximum element of the array
        */

        /// <summary>
        /// T.C. = O(A*A), S.C. = O(1)
        /// </summary>
        public static int Solve(List<int> A)
        {
            int N = A.Count;
            int min = A[0];
            int max = A[0];
            int ans = N;

            for (int i = 1; i < N; i++)
            {
                if (A[i] < min)
                    min = A[i];

                if (A[i] > max)
                    max = A[i];
            }

            if (min == max)
                return 1;

            for (int i = 0; i < N; i++)
            {
                if (A[i] == min)
                {
                    for (int j = i + 1; j < N; j++)
                    {
                        if (A[j] == max)
                        {
                            int length = j - i + 1;
                            if (length < ans)
                                ans = length;
                            break;
                        }
                    }
                }
                else if (A[i] == max)
                {
                    for (int j = i + 1; j < N; j++)
                    {
                        if (A[j] == min)
                        {
                            int length = j - i + 1;
                            if (length < ans)
                                ans = length;
                            break;
                        }
                    }
                }
            }

            return ans;
        }

        /// <summary>
        /// T.C. = O(A), S.C. = O(1)
        /// </summary>
        public static int SolveWithCarryForward(List<int> A)
        {
            int N = A.Count;
            int min = A[0];
            int max = A[0];
            int ans = N;
            int minIndex = -1, maxIndex = -1;

            for (int i = 1; i < N; i++)
            {
                if (A[i] < min)
                    min = A[i];

                if (A[i] > max)
                    max = A[i];
            }

            if (min == max)
                return 1;

            //processing from left to right
            for (int i = 0; i < N; i++)
            {
                if (A[i] == min)
                {
                    minIndex = i;
                    if(maxIndex != -1)
                    {
                        int length = minIndex - maxIndex + 1;
                        if(length < ans)
                            ans = length;
                    }
                }
                else if (A[i] == max)
                {
                    maxIndex = i;
                    if (minIndex != -1)
                    {
                        int length = maxIndex - minIndex + 1;
                        if (length < ans)
                            ans = length;
                    }
                }
            }


            minIndex = -1;
            maxIndex = -1;
            //processing from left to right
            for (int i = N-1; i >= 0; i--)
            {
                if (A[i] == min)
                {
                    minIndex = i;
                    if (maxIndex != -1)
                    {
                        int length = maxIndex - minIndex + 1;
                        if (length < ans)
                            ans = length;
                    }
                }
                else if (A[i] == max)
                {
                    maxIndex = i;
                    if (minIndex != -1)
                    {
                        int length = minIndex - maxIndex + 1;
                        if (length < ans)
                            ans = length;
                    }
                }
            }

            return ans;
        }
    }
}
