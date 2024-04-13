namespace ProblemSolving.DS.MohamedElSherif
{
    // You can define other methods, fields, classes and namespaces here
    public class SumSquaredDivisors
    {
        public static string listSquared(long m, long n)
        {
            Dictionary<long, long> dict = new Dictionary<long, long>();
            for (long i = m; i <= n; i++)
            {
                var input =
                    Divisors(i).Select(divisor => divisor * divisor)
                    .Sum();
                var isSquared = IsSquared(input);
                if (isSquared)
                    dict.Add(i, input);
            }
            return "[" + string.Join(", ", dict) + "]";
        }
        public static List<long> Divisors(long input)
        {
            List<long> list = new List<long>();
            for (var i = 1; i <= input; i++)
            {
                if (input % i == 0)
                {
                    list.Add(i);
                }
            }
            return list;
        }
        public static bool IsSquared(long input)
        {
            var Sqrt = (long)Math.Sqrt(input);
            return (Sqrt * Sqrt) == input;
        }
    }

    public class PyramidSlideDown
    {
        /*
         var mediumPyramid = new[]
          {
              new [] {75},
              new [] {95, 64},
              new [] {17, 47, 82},
              new [] {18, 35, 87, 10},
              new [] {20,  4, 82, 47, 65},
              new [] {19,  1, 23, 75,  3, 34},
              new [] {88,  2, 77, 73,  7, 63, 67},
              new [] {99, 65,  4, 28,  6, 16, 70, 92},
              new [] {41, 41, 26, 56, 83, 40, 80, 70, 33},
              new [] {41, 48, 72, 33, 47, 32, 37, 16, 94, 29},
              new [] {53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14},
              new [] {70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57},
              new [] {91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48},
              new [] {63, 66,  4, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31},
              new [] { 4, 62, 98, 27, 23,  9, 70, 98, 73, 93, 38, 53, 60,  4, 23}
          };
         */
        public static int LongestSlideDown(int[][] pyramid)
        {
            int sum = 0;
            if (pyramid.Length >= 2)
            {
                sum = pyramid[0][0] + pyramid[1].ToList().OrderByDescending(x => x).ToList()[0];
            }
            int cnt = 1;
            foreach (var arr in pyramid)
            {

                if (cnt > 2)
                {
                    IEnumerable<int>? copy = arr.Skip(1).Take(arr.Length - 2);
                    sum += copy.OrderByDescending(c => c).Take(1).ToList()[0];
                }
                cnt++;
            }
            return sum;
        }
    }
}
