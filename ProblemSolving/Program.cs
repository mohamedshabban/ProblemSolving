using System.Text;
namespace ProblemSolving
{
    public class SolutionLengthOfLongestSubstring
    {
        public int LengthOfLongestSubstring(string str)
        {
            int maxLength = 0;
            try
            {
                //bbbb
                for (int i = 0; i < str.Length; i++)
                {
                    for (int j = i + 1; j < str.Length; j++)
                    {
                        var subString = str.Substring(i, j);
                        int len = str.Split(subString)
                            .Where(c => !c.Equals(""))
                            .ToList().Count;
                        if (len > maxLength)
                            maxLength = len;
                    }
                }
                return maxLength;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return maxLength;
            }
        }
    }
    public class TwoSumSolution
    {
        //Input: nums = [2,7,11,15], target = 9
        //Output: [0,1]
        public int[] TwoSum(List<int> nums, int target)
        {
            List<int> list = nums.ToList();
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    var total = list[i] + list[j];
                    if (total == target)
                    {
                        return new int[2] { i, j };
                    }
                }
            }
            return new int[0];
        }

    }

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
            for (int i = left; i <= right; i++)
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
        static int[] TopKFrequent(int[] nums, int k)
        {
            var xx =
                 nums.GroupBy(c => c)
                 .ToDictionary(group => group.Key
                 , group => group.Count())
                 .OrderByDescending(c => c.Value)
                 .Take(k);
            var yy = xx.Take(k)
                .Select(c => c.Key)
                .ToArray();
            return yy;
        }
        static int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Length;
            int[] answer = new int[n];

            // Compute left products
            int leftProduct = 1;
            for (int i = 0; i < n; i++)
            {
                answer[i] = leftProduct;
                leftProduct *= nums[i];
            }

            // Compute right products and multiply with left products
            int rightProduct = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                answer[i] *= rightProduct;
                rightProduct *= nums[i];
            }

            return answer;
            //int[] answer = new int[nums.Length];
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    int temp = nums[i];
            //    nums[i] = 1;
            //    answer[i] = nums.Aggregate(1, (a, b) => a * b);
            //    nums[i] = temp;
            //}
            //return answer;
        }
        static int Fibonacci(int n)
        {
            int[] arr = new int[n + 1];
            arr[0] = 1;
            if (n == 0)
                return arr[0];
            arr[1] = 1;
            if (n == 1)
                return arr[1];
            for (int i = 2; i <= n; i++)
                arr[i] = arr[i - 1] + arr[i - 2];
            return arr[n];
        }
        static void Main()
        {
            Console.WriteLine(Fibonacci(7));
        }
    }
}