namespace ProblemSolvingDSA.Arrays
{
    internal class _1_CountOfElements
    {
        /*
        Given an array A of N integers. 
        Count the number of elements that have at least 1 elements greater than itself.

        Input Format
        First and only argument is an array of integers A.

        Output Format
        Return the count of elements.
        */

        /// <summary>
        /// T.C. = O(A), S.C. = O(1)
        /// </summary>
        public static int Solve(List<int> A)
        {
            int count = 0;
            int max = A[0];
            for (int i = 1; i < A.Count; i++)
            {
                if (A[i] > max)
                    max = A[i];
            }

            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] < max)
                    count++;
            }

            return count;
        }

        /// <summary>
        /// T.C. = O(A), S.C. = O(1)
        /// </summary>
        public static int SolveWithOneLoop(List<int> A)
        {
            int maxCount = 1;
            int max = A[0];
            
            for (int i = 1; i < A.Count; i++)
            {
                if (A[i] == max)
                {
                    maxCount++;
                }

                if (A[i] > max)
                {
                    max = A[i];
                    maxCount = 1;
                }
            }

            return A.Count - maxCount;
        }
    }
}
