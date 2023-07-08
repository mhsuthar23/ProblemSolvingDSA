namespace ProblemSolvingDSA.Arrays
{
    internal class _8_ProductArrayPuzzle
    {
        /*
        Given an array of integers A, find and return the product array of the same size where the ith element of the product array will be equal to the product of all the elements divided by the ith element of the array.

        Note: It is always possible to form the product array with integer (32 bit) values. Solve it without using the division operator.

        Input Format
        The only argument given is the integer array A.
        
        Output Format
        Return the product array.
        */

        /// <summary>
        /// T.C. = O(A*A), S.C. = O(A)
        /// </summary>
        public static List<int> Solve(List<int> A)
        {
            List<int> AProduct = new List<int>();
            for (int i = 0; i < A.Count; i++)
            {
                int leftProduct = 1;
                int rightProduct = 1;

                for (int j = 0; j < i; j++)
                {
                    leftProduct *= A[j];
                }

                for (int j = i+1; j < A.Count; j++)
                {
                    rightProduct *= A[j];
                }

                AProduct.Add(leftProduct * rightProduct);
            }

            return AProduct;
        }

        /// <summary>
        /// T.C. = O(A), S.C. = O(A)
        /// </summary>
        public static List<int> SolveWithPrefixSuffixProduct(List<int> A)
        {
            List<int> AProduct = new List<int>();
            int[] APrefixProduct = new int[A.Count];
            int[] APostfixProduct = new int[A.Count];
            
            //prefix product
            APrefixProduct[0] = 1;
            for (int i = 1; i < A.Count; i++)
            {
                APrefixProduct[i] = APrefixProduct[i - 1] * A[i - 1];
            }

            //postfix product
            APostfixProduct[A.Count - 1] = 1;

            for (int i = A.Count - 2; i >= 0; i--)
            {
                APostfixProduct[i] = APostfixProduct[i + 1] * A[i + 1];
            }

            for (int i = 0; i < A.Count; i++)
            {
                AProduct.Add(APrefixProduct[i] * APostfixProduct[i]);
            }

            return AProduct;
        }
    }
}
