using ProblemSolvingDSA.Arrays;
using System.Text.Json;

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

            RangeSumQuery();
            EquilibriumIndexOfAnArray();
            EvenNumbersInRange();
            ProductArrayPuzzle();
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
            Console.WriteLine(JsonSerializer.Serialize(resultA));
        }

        static void ArrayRotation()
        {
            Console.WriteLine("ArrayRotation:");
            List<int> A = new List<int>() { 1, 2, 3, 4 };
            int B = 2;

            var resultA = _4_ArrayRotation.Solve(A, B);
            Console.WriteLine(JsonSerializer.Serialize(resultA));
        }

        static void RangeSumQuery()
        {
            Console.WriteLine("RangeSumQuery:");
            List<int> A = new List<int>() { 1, 2, 3, 4, 5};
            List<List<int>> B = new List<List<int>>() 
            { 
                new List<int>() { 0, 3 }, 
                new List<int>() { 1, 2 }
            };

            var resultA = _5_RangeSumQuery.Solve(A, B);
            var resultB = _5_RangeSumQuery.SolveWithPrefixSum(A, B);
            Console.WriteLine(JsonSerializer.Serialize(resultA));
            Console.WriteLine(JsonSerializer.Serialize(resultB));
        }

        static void EquilibriumIndexOfAnArray()
        {
            Console.WriteLine("EquilibriumIndexOfAnArray:");
            List<int> A = new List<int>() { 1, 2, 3, 7, 1, 2, 3 };

            var result = _6_EquilibriumIndexOfAnArray.Solve(A);
            Console.WriteLine(result);
        }

        static void EvenNumbersInRange()
        {
            Console.WriteLine("EvenNumbersInRange:");
            List<int> A = new List<int>() { 1, 2, 3, 4, 5 };
            List<List<int>> B = new List<List<int>>()
            {
                new List<int>() { 0, 3 },
                new List<int>() { 1, 2 }
            };

            var resultA = _7_EvenNumbersInRange.Solve(A,B);
            var resultB = _7_EvenNumbersInRange.SolveWithPrefixSum(A, B);
            Console.WriteLine(JsonSerializer.Serialize(resultA));
            Console.WriteLine(JsonSerializer.Serialize(resultB));
        }

        static void ProductArrayPuzzle()
        {
            Console.WriteLine("ProductArrayPuzzle:");
            List<int> A = new List<int>() { 5, 1, 10, 1 };

            var resultA = _8_ProductArrayPuzzle.Solve(A);
            var resultB = _8_ProductArrayPuzzle.SolveWithPrefixSuffixProduct(A);
            Console.WriteLine(JsonSerializer.Serialize(resultA));
            Console.WriteLine(JsonSerializer.Serialize(resultB));

        }
    }
}