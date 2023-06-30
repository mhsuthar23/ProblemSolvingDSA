namespace ProblemSolvingDSA.Arrays
{
    internal class _4_ArrayRotation
    {
        /*
        Problem Description
        Given an integer array A of size N and an integer B, you have to return the same array after rotating it B times towards the right.

        Input Format
        The first argument given is the integer array A.
        The second argument given is the integer B.


        Output Format
        Return the array A after rotating it B times to the right
        */
        public static List<int> Solve(List<int> A, int B)
        {
            B = B % A.Count;

            //reverse entire array
            _3_ReverseInRange.Solve(A, 0, A.Count - 1);

            //reverse left part til Bth element
            _3_ReverseInRange.Solve(A, 0, B - 1);

            //reverse right part starting after Bth element
            _3_ReverseInRange.Solve(A, B, A.Count - 1);

            return A;
        }
    }
}
