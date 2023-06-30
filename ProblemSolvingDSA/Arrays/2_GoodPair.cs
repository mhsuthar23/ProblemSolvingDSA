namespace ProblemSolvingDSA.Arrays
{
    internal class _2_GoodPair
    {
        /*
        Given an array A and an integer B. A pair(i, j) in the array is a good pair if i != j and (A[i] + A[j] == B). 
        Check if any good pair exist or not.
        
        Input Format
        First argument is an integer array A.
        Second argument is an integer B.

        Output Format
        Return 1 if good pair exist otherwise return 0.
        */
        public static int Solve(List<int> A, int B)
        {
            for (int i = 0; i < A.Count; i++)
            {
                for (int j = 0; j < A.Count; j++)
                {
                    if (i != j && (A[i] + A[j] == B))
                        return 1;
                }
            }

            return 0;
        }
    }
}
