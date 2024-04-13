namespace ProblemSolving.DS._00Arrays
{
    public class Solution01
    {

        public int[] GetConcatenation(int[] nums)
        {
            int[] result = new int[nums.Length * 2];
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = nums[i];
            }
            for (int i = nums.Length; i < (nums.Length * 2); i++)
            {
                result[i] = nums[i];
            }
            return result;
        }
    }
}
