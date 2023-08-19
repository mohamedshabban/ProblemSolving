using System.Text;
using System.Text.RegularExpressions;

namespace ProblemSolving
{
    public class NumArray
    {
        private readonly int[] numbers;
        public NumArray(int[] nums)
        {
            numbers = nums;
        }

        public int SumRange(int left, int right)
        {
            int cnt = 0;
            for (int i = left;i<=right;i++)
            {
                cnt += numbers[i];
            }
            return cnt;
        }
    }
    internal class Program
    {
        public static Dictionary<int, int> memo = new Dictionary<int, int>() { { 1, 1 }, { 2, 2 } };
        public static int ClimbStairs(int N)
        {
            if (memo.ContainsKey(N))
                return memo[N];

            int left = ClimbStairs(N - 2);
            memo[N - 2] = left;

            int right = ClimbStairs(N - 1);
            memo[N - 1] = right;
            return left + right;
        }

        public static int MaxProfit(int[] prices)
        {
            //[7,1,5,3,6,4]
            List<int> result = prices.ToList();
            int profit = 0;
            for (int i = 0; i < result.Count; i++)
            {
                if (prices[i] < result.GetRange(i, result.Count - i).Max() && profit < (result.GetRange(i, result.Count - i).Max() - prices[i]))
                {
                    profit = result.GetRange(i, result.Count - i).Max() - prices[i];
                }

            }
            return profit;
        }

        public static int[] CountBits(int n)
        {
            //
            n = n + 1;
            var list = new List<int>();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                string num = Convert.ToString(i, 2);
                num = num.Replace("0", "");
                if (num == "")
                    list.Add(0);
                else
                    list.Add(num.Length);

            }
            return list.ToArray();
        }
        static void Main()
        {
            
        }
    }
}