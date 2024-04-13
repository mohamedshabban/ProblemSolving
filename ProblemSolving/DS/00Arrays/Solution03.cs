namespace ProblemSolving.DS._00Arrays
{
    public class Solution03
    {
        public int ThreeSumClosest(int[] arr, int target)
        {
            int len = arr.Length;
            var list = arr.ToList();
            List<int> result = new List<int>();
            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    for (int k = j + 1; k < len; k++)
                    {
                        result.Add(list[i] + list[k] + list[j]);
                    }
                }
            }
            return result.MinBy(x => Math.Abs(x - target));
        }
    }
}
