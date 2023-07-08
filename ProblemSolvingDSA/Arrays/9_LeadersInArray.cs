namespace ProblemSolvingDSA.Arrays
{
    internal class _10_LeadersInArray
    {
        /*
        Given an integer array A containing N distinct integers, you have to find all the leaders in array A. An element is a leader if it is strictly greater than all the elements to its right side.

        NOTE: The rightmost element is always a leader.

        Input Format
        There is a single input argument which a integer array A

        Output Format
        Return an integer array denoting all the leader elements of the array.
        */

        /// <summary>
        /// T.C. = O(A*A), S.C. = O(A)
        /// </summary>
        public static List<int> Solve(List<int> A)
        {
            List<int> leaders = new List<int>();
            int N = A.Count;

            leaders.Add(A[N - 1]);

            for (int i = N - 2; i >= 0; i--)
            {
                int max = A[i + 1];

                for (int j = i + 2; j < N; j++)
                {
                    if (A[j] > max)
                        max = A[j];
                }

                if (A[i] > max)
                    leaders.Add(A[i]);
            }

            return leaders;
        }

        /// <summary>
        /// T.C. = O(A), S.C. = O(A)
        /// </summary>
        public static List<int> SolveWithCarryForward(List<int> A)
        {
            List<int> leaders = new List<int>();
            int N = A.Count;
            int max = A[N - 1];
            leaders.Add(max);

            for (int i = N - 2; i >= 0; i--)
            {
                if (A[i] > max)
                {
                    max = A[i];
                    leaders.Add(A[i]);
                }
            }

            return leaders;
        }
    }
}
