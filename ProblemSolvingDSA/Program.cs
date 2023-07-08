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

            LeadersInArray();
            ClosestMinMax();
            SpecialSubsequences();

            BestTimeToBuyAndSell();
            AmazingSubArrays();
            EvenSubArrays();
            Bulbs();
            PickFromBothSides();
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

        static void LeadersInArray()
        {
            Console.WriteLine("LeadersInArray:");
            List<int> A = new List<int>() { 16, 17, 4, 3, 5, 2 };

            var resultA = _10_LeadersInArray.Solve(A);
            var resultB = _10_LeadersInArray.SolveWithCarryForward(A);
            Console.WriteLine(JsonSerializer.Serialize(resultA));
            Console.WriteLine(JsonSerializer.Serialize(resultB));
        }

        static void ClosestMinMax()
        {
            Console.WriteLine("ClosestMinMax:");
            List<int> A = new List<int>() { 108, 307, 173, 448, 377 };

            var result1 = _10_ClosestMinMax.Solve(A);
            var result2 = _10_ClosestMinMax.SolveWithCarryForward(A);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }

        static void SpecialSubsequences()
        {
            Console.WriteLine("SpecialSubsequences:");
            string A = "GUGPUAGAFQBMPYAGGAAOALAELGGGAOGLGEGZ";

            var result1 = _11_SpecialSubsequences.Solve(A);
            var result2 = _11_SpecialSubsequences.SolveWithSuffixSum(A);
            var result3 = _11_SpecialSubsequences.SolveWithCarryForward(A);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
        }

        static void BestTimeToBuyAndSell()
        {
            Console.WriteLine("BestTimeToBuyAndSell:");
            //List<int> A = new List<int>() { 5607815, 3316671, 8567241, 1953452, 5821723, 2107782, 3199656, 6500702, 1660943, 6106567, 4568376, 8233467, 1638185, 377730, 5259135, 6478497, 6263692, 6552746, 3362077, 5708016, 4539867, 3711341, 5627255, 277600, 6143721, 6259753, 644473, 1507454, 5325058, 6165165, 763455, 9984969, 6976876, 3892567, 5070435, 3819938, 6924694, 933602, 7834567, 8291211, 6739477, 9545438, 3206097, 2323842, 7803322, 1174139, 3607685, 191039, 9269119, 3552617, 1102590, 4356323, 3522620, 1903537, 6280411, 2766528, 8424337, 798933, 4870234, 4125373, 6170402, 3232242, 4406431, 9635073, 5723402, 2327910, 8163383, 5725707, 5758243, 454498, 3448372, 6540483, 7792016, 8569648, 8405688, 7659716, 443181, 1904980, 8752774, 9782165, 3263420, 2362405, 1272399, 1975615, 4785564, 3483341, 8506282, 7863969, 5004535, 9952854, 6918848, 8383187, 9577668, 6675789, 1811729, 4958207, 2478774, 578257, 9573520, 4529624, 9746119, 5062452, 1196924, 3295753, 4622543, 3897334, 2580607, 3386517, 4009710, 5881831, 2870213, 3280031, 8424727, 4443991, 3244444, 9964755, 4594031, 7839146, 5373680, 2667045, 6297282, 6913168, 5055678, 2146177, 8295695, 1359236, 7583380, 2719127, 5199640, 5601038, 1312220, 4304211, 6553177, 8199378, 7163949, 2023984, 9975949, 9232517, 7609041, 5985920, 2054590, 454561, 5482916, 2660135, 8527838, 5410594, 8451992, 7345999, 2234795, 8673975, 3633757, 9745518, 9387763, 560237, 9080534, 389344, 1167825, 4136688, 7053800, 2653286, 1612350, 324971, 5303542, 7695126, 6462474, 1477306, 8658282, 5516828, 3331274, 7235006, 3043695, 464183, 791128, 5146645, 1268058, 9047045, 5906692, 2852023, 2808918, 424668, 3783527, 870647, 9842209, 8769941, 3230988, 4080059, 808752, 2986269, 8129732, 926836, 9900762, 5331852, 2426541, 9206044, 2499321, 7366685, 972680, 106298, 5150104, 9403466, 5873953, 7739451, 6417370, 3236401, 6093656, 5707253, 5454452, 6107483, 9374599, 9312912, 6579208, 4665036, 1630996, 4482086, 1223359, 5925059, 6524074, 6518129, 6895018, 2857112, 1636513, 1239114, 8312802, 1663398, 572307, 4703625, 5211559, 1380893, 1456101, 6065819, 9600368, 9441022, 2123889, 2184671, 7106036, 3965869, 4920784, 8015842, 4114180, 3599133, 5923431, 1808461, 1217301, 1290812, 5807580, 4731508, 4940020, 664661, 6448821, 6492504, 5503474, 9363166, 2560913, 1978557, 5269068, 6743412, 4613052, 6518355, 8765820, 8481497, 7208085, 1178264, 6798102, 4020672, 4951009, 3724074, 9127609, 983019, 1854053, 9501770, 2899978, 2171135, 4173484, 9873035, 1638504, 2651438, 5832207, 9705774, 7315991, 9817970, 8629270, 613202, 6918296, 1776124, 6962356, 6975889, 895334, 4811405, 850100, 8719686, 1806236, 6467911, 1990911, 5751179, 9353956, 4803564, 1110447, 7415615, 7697424, 9364223, 2609202, 9980425, 6504662, 438730, 7096, 864543, 5588596, 8553444, 5555148, 2654639, 6310408, 9534846, 5696310, 2928890, 1980839, 9822702, 7803880, 2356800, 3361458, 8987980, 6172620, 7747543, 4169127, 2728565, 3050660, 3670161, 1022716, 434886, 3411803, 6259457, 2317992, 4853792, 8705581, 292988, 7470821, 6403835, 9553616, 4337225, 2659007, 730082, 2559847, 3945856, 2153601, 5237701, 5764748, 9660799, 4539969, 170685, 212370, 8282356, 5506991, 3372242, 4863239, 4632840, 7486372, 3404761, 2030008, 7126876, 4131493, 8734738, 8314838, 1548351, 6480805, 4249811, 1571259, 9205448, 2427521, 832867, 3566223, 5745791, 2597785, 6431230, 6359451, 9767646, 574420, 4342246, 614000, 7690489, 6840508, 6111863, 644347, 1231520, 742068, 7986519, 9827536, 5543467, 7369407, 5057635, 7923319, 8576725, 6900488, 1200118, 568580, 7373741, 2558364, 174833, 7613505, 8434181, 1464602, 7812576, 27102, 4791057, 9868005, 2826819, 5442788, 5380453, 3597562, 3908561, 5398211, 5315627, 3207827, 8637328, 8597955, 2497694, 2250161, 4640236, 9777914, 1460764, 4614905, 3622121, 2933308, 212147, 6732249, 6934918, 4106945, 7820238, 1263668, 7934723, 10851, 4748252, 1868471, 6779158, 5039908, 2354783, 5305700, 907512, 8473936, 2892992, 7163961, 5847552, 7663992, 3022118, 5388845, 129743, 6759444, 3761572, 2886094, 3776463, 2262452, 9202035, 4709130, 4142810, 9528526, 8284933, 3601048, 7218568, 4007635, 6851267, 1094400, 1157543, 8896396, 3630488, 3913569, 7431417, 7940810, 2431491, 9398399, 3917452, 378696, 6595832, 2849208, 6774198, 2892564, 8601365, 3965601, 1361602, 3610413, 9097647, 6822748, 768909, 3940412, 7807849, 3962640, 5457629, 68084, 3808344, 8086366, 6199981, 630330, 7017026, 6581528, 7991368, 7260849, 2488089, 9627795, 7054955, 3937726, 6101693, 2209522, 9073455, 5212540, 6002591, 2213056, 9506702, 95580, 8278868, 1961097, 8405656, 5790083, 4815501, 4049881, 3730381, 9401831, 9315385, 4729693, 3244170, 4530984, 8447594, 3158546, 4527686, 1005095, 2909568, 5099776, 7310182, 2634443, 3935595, 1446518, 2008850, 9148499, 4008794, 4016283, 3800271, 4121992, 6822984, 8652133, 4368449, 3678178, 5408316, 2952491, 3449449, 5531885, 2981026, 8911713, 4979659, 9811554, 9131874, 4948553, 8560318, 8090951, 5279869, 6495665, 2639388, 3872645, 751353, 270170, 5632428, 5262014, 9439606, 8380009, 1683881, 7709117, 1609187, 2775511, 8713611, 9673113, 8266178, 3247266, 7688598, 2419076, 8130726, 4281383, 4098387, 750777, 3554234, 5167562, 3587083, 6456217, 3375243, 8057274, 3426629, 8761015, 2592124, 4583593, 124011, 8193267, 8906919, 404699, 4395250, 2814951, 2858604, 9677450, 4037192, 48661, 7667293, 5855839, 5378896, 9976243, 4591492, 6976922, 6144942, 6781098, 8056420, 7323926, 689153, 8798036, 3109311, 8048219, 8955574, 309664, 3471841, 3654327, 2291916, 8080146, 6792197, 2406223, 9796082, 8676278, 1094297, 5540654, 9673603, 5108186, 3610730, 1871505, 4474810, 8137990, 7226681, 5261676, 7791659, 2778211, 6382581, 232040, 3504602, 646515, 6453725, 98782, 817896, 5748588, 3941055, 1285149, 4337264, 4861734, 8300993, 6749827, 5695724, 3172210, 5424488, 1851985, 6138318, 3192075, 4163764, 1702368, 9721295, 4647749, 1297078, 2575264, 8872304, 3375483, 3576595, 9263545, 5358260, 4602058, 6726911, 724603, 5489608, 4273306, 9447189, 7730837, 7578065, 9442551, 4076682, 5273670, 3144124, 1068838, 8007390, 1349218, 9481145, 8747986, 1299448, 2942009, 6032122, 9074683, 5317375, 7540153, 923821, 7029808, 7081268, 3239598, 1900259, 444249, 6208751, 2176965, 5301232, 4033708, 6569996, 2601589, 4932029, 368930, 8008150, 8278580, 975447, 4769515, 40109, 9065589, 2830638, 4373745, 962734, 359324, 9230525, 7782387, 3143786, 8592633, 1270713, 4652111, 8138868, 9251607, 2015304, 6491330, 701924, 4385305, 9020963, 8443216, 2843285, 2597757, 4567213, 3431958, 7318803, 406638, 1410336, 9772604, 6193593, 3886822, 2615443, 4811289, 3258804, 3922039, 259239, 5033857, 1220404, 772527, 8277795, 6296312, 1260979, 2415601 };
            List<int> A = new List<int>() { 1, 4, 5, 2, 4 };

            int result1 = _12_BestTimeToBuyAndSell.SolveWithPrefixSum(A);
            int result2 = _12_BestTimeToBuyAndSell.SolveWithCarryForward(A);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }

        static void AmazingSubArrays()
        {
            Console.WriteLine("AmazingSubArrays:");
            string A = "GUGPUAGAFQBMPYAGGAAOALAELGGGAOGLGEGZE";

            var result1 = _13_AmazingSubArrays.Solve(A);
            var result2 = _13_AmazingSubArrays.SolveWithSuffixSum(A);
            var result3 = _13_AmazingSubArrays.SolveWithCarryForward(A);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
        }

        static void EvenSubArrays()
        {
            Console.WriteLine("EvenSubArrays:");
            List<int> A = new List<int>() { 2, 4, 8, 7, 6 };

            string result1 = _14_EvenSubArrays.Solve(A);
            Console.WriteLine(result1);
        }

        static void Bulbs()
        {
            Console.WriteLine("Bulbs:");
            List<int> A = new List<int>() { 0, 0, 1, 1, 0, 0, 1 };

            int result2 = _15_Bulbs.SolveWithCarryForward(A);
            int result1 = _15_Bulbs.Solve(A);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }

        static void PickFromBothSides()
        {
            Console.WriteLine("PickFromBothSides:");
            List<int> A = new List<int>() { 2, 3, -1, 4, 2, 1 };
            int B = 6;
            int result1 = _16_PickFromBothSides.Solve(A, B);
            int result2 = _16_PickFromBothSides.SolveWithCarryForward(A, B);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }
}