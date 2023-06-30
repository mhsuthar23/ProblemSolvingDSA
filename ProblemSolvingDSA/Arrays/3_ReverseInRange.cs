using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingDSA.Arrays
{
    internal class _3_ReverseInRange
    {
        /*
        Problem Description
        Given an array A of N integers and also given two integers B and C. Reverse the elements of the array A within the given inclusive range [B, C].

        Input Format
        The first argument A is an array of integer.
        The second and third arguments are integers B and C

        Output Format
        Return the array A after reversing in the given range.
        */
        public static List<int> Solve(List<int> A, int B, int C)
        {
            int i = B, j = C;
            while (i < j)
            {
                int tmp = A[i];
                A[i] = A[j];
                A[j] = tmp;

                i++;
                j--;
            }

            return A;
        }

        public static List<int> SolveWithForLoop(List<int> A, int B, int C)
        {
            for (int i = B, j = C; i < j; i++, j--)
            {
                int tmp = A[i];
                A[i] = A[j];
                A[j] = tmp;
            }

            return A;
        }        
    }
}
