using ProblemSolvingDSA.Arrays;
using System.Net.Http.Json;

namespace ProblemSolvingDSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CountOfElements();
            GoodPair();
            ReverseInRange();
            ArrayRotation();
        }

        static void CountOfElements()
        {
            Console.WriteLine("CountOfElements:");
            List<int> A = new List<int>() { 2, 3, 10, 7,3,2,10,8};

            int result1 = _1_CountOfElements.Solve(A);
            int result2 = _1_CountOfElements.SolveWithOneLoop(A);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }

        static void GoodPair()
        {
            Console.WriteLine("GoodPair:");
            List<int> A = new List<int>() { 1, 2, 3, 4 };
            int B = 7;

            var result = _2_GoodPair.Solve(A, B);
            Console.WriteLine(result);
        }

        static void ReverseInRange()
        {
            Console.WriteLine("ReverseInRange:");
            List<int> A = new List<int>() { 1, 2, 3, 4 };
            int B = 2;
            int C = 3;

            var resultA = _3_ReverseInRange.Solve(A, B, C);
            Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(resultA));
        }

        static void ArrayRotation()
        {
            Console.WriteLine("ArrayRotation:");
            List<int> A = new List<int>() { 1, 2, 3, 4 };
            int B = 2;

            var resultA = _4_ArrayRotation.Solve(A, B);
            Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(resultA));
        }
    }
}