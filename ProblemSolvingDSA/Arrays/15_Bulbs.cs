namespace ProblemSolvingDSA.Arrays
{
    internal class _15_Bulbs
    {
        /*
        A wire connects N light bulbs.
        Each bulb has a switch associated with it; however, due to faulty wiring, a switch also changes the state of all the bulbs to the right of the current bulb.
        Given an initial state of all bulbs, find the minimum number of switches you have to press to turn on all the bulbs.
        You can press the same switch multiple times.

        Note: 0 represents the bulb is off and 1 represents the bulb is on. 

        Input Format
        The first and the only argument contains an integer array A, of size N.

        Output Format
        Return an integer representing the minimum number of switches required.
        */

        /// <summary>
        /// T.C. = O(A * A), S.C. = O(1)
        /// </summary>
        public static int Solve(List<int> A)
        {
            int N = A.Count;
            int switchCount = 0;

            for (int i = 0; i < N; i++)
            {
                if (A[i] == 0)
                {
                    A[i]++;
                    switchCount++;

                    for (int j = i + 1; j < N; j++)
                    {
                        A[j] = 1 - A[j];
                    }
                }
            }

            return switchCount;
        }

        /// <summary>
        /// T.C. = O(A), S.C. = O(1)
        /// </summary>
        public static int SolveWithCarryForward(List<int> A)
        {
            int N = A.Count;
            int switchCount = 0;

            for (int i = 0; i < N; i++)
            {
                int state;
                if (switchCount % 2 == 0)
                    state = A[i];
                else
                    state = 1 - A[i];

                if (state == 0)
                    switchCount++;
            }

            return switchCount;
        }
    }
}
