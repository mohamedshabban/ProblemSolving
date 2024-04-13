using System.Text;

namespace PracticeStrings
{
    internal class Program
    {
        static bool IsPalindrome(int x)
        {
            string str = x.ToString();
            StringBuilder strReversed = new StringBuilder("");
            for (int i = str.Length - 1; i >= 0; i--)
            {
                strReversed.Append(str[i]);
            }
            if (str.Equals(strReversed.ToString())) return true;
            return false;
        }
        static int RomanToInt(string s)
        {
            s = s.Replace("IV", "IIII");
            s = s.Replace("IX", "VIIII");
            s = s.Replace("XL", "XXXX");
            s = s.Replace("XC", "LXXXX");
            s = s.Replace("CD", "CCCC");
            s = s.Replace("CM", "DCCCC");
            Dictionary<char, int> dict = new Dictionary<char, int>();
            dict.Add('I', 1);
            dict.Add('V', 5);
            dict.Add('X', 10);
            dict.Add('L', 50);
            dict.Add('C', 100);
            dict.Add('D', 500);
            dict.Add('M', 1000);

            int cnt = 0;
            for (int i = 0; i < s.Length; i++)
            {
                cnt += dict[s[i]];
            }
            return cnt;
        }
        static bool IsValid(string str)
        {
            if (str.Length == 1)
                return false;
            List<int> Queue = new List<int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(')
                { Queue.Add(1); continue; }
                if (str[i] == '[')
                { Queue.Add(2); continue; }
                if (str[i] == '{')
                { Queue.Add(3); continue; }

                if (Queue.Count == 0)
                    return false;

                if (str[i] == ')' && Queue[Queue.Count - 1] == 1)
                {
                    Queue.RemoveAt(Queue.Count - 1);
                    continue;
                }
                if (str[i] == ']' && Queue[Queue.Count - 1] == 2)
                {
                    Queue.RemoveAt(Queue.Count - 1);
                    continue;
                }
                if (str[i] == '}' && Queue[Queue.Count - 1] == 3)
                {
                    Queue.RemoveAt(Queue.Count - 1);
                    continue;
                }
                return false;
            }
            return Queue.Count == 0;

        }
        static string LongestCommonPrefix(string[] ArrayOfStrings)
        {
            StringBuilder res = new StringBuilder("");
            ArrayOfStrings = ArrayOfStrings.OrderBy(x => x.Length).ToArray();
            //"flow","flower","flight"
            for (int i = 0; i < ArrayOfStrings[0].Length; i++)
            {
                foreach (string s in ArrayOfStrings)
                {
                    if (i == s.Length || s[i] != ArrayOfStrings[0][i])//max string
                    {
                        return res.ToString();
                    }
                }
                res.Append(ArrayOfStrings[0][i]);
            }
            return res.ToString();
        }
        static int RemoveDuplicates(int[] nums)
        {
            int i = 1;
            foreach (int item in nums)
            {
                if (nums[i - 1] != item) nums[i++] = item;
            }
            return i;
        }
        static int RemoveElement(int[] nums, int val)
        {
            int lastUpdatedIndex = 0;
            foreach (int current in nums)
            {
                if (current != val)
                {
                    nums[lastUpdatedIndex] = current;
                    lastUpdatedIndex++;
                }
            }
            return lastUpdatedIndex;
        }
        static int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrWhiteSpace(haystack))
            {
                return -1;
            }
            if (string.IsNullOrWhiteSpace(needle))
            {
                return -1;
            }
            if (haystack.Length >= needle.Length)
            {
                return haystack.IndexOf(needle, StringComparison.CurrentCultureIgnoreCase);
            }
            return -1;
        }
        static void Main(string[] args)
        {

        }
    }
}