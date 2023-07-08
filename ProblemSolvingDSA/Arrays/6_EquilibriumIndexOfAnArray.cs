namespace ProblemSolvingDSA.Arrays
{
    internal class _6_EquilibriumIndexOfAnArray
    {
        /*
        You are given an array A of integers of size N.
        Your task is to find the equilibrium index of the given array
        The equilibrium index of an array is an index such that the sum of elements at lower indexes is equal to the sum of elements at higher indexes.
        If there are no elements that are at lower indexes or at higher indexes, then the corresponding sum of elements is considered as 0.

        Note:
        Array indexing starts from 0.
        If there is no equilibrium index then return -1.
        If there are more than one equilibrium indexes then return the minimum index.
        
        Input Format
        First arugment is an array A .

        Output Format
        Return the equilibrium index of the given array. If no such index is found then return -1.
        */

        /// <summary>
        /// T.C. = O(A), S.C. = O(A)
        /// </summary>
        public static int Solve(List<int> A)
        {
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

            for (int i = 0; i < APrefixSum.Count; i++)
            {
                long left = 0;
                if (i > 0)
                    left = APrefixSum[i - 1];

                long right = APrefixSum[APrefixSum.Count - 1] - APrefixSum[i];

                if (left == right)
                    return i;
            }


            return -1;
        }
    }
}
