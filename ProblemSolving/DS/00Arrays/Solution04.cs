namespace ProblemSolving.DS._00Arrays
{
    public class Solution04
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            List<int> list1 = nums1.ToList();
            List<int> list2 = nums2.ToList();
            foreach (var item in list1)
            {
                list2.Add(item);
            }
            list2 = list2.OrderBy(c => c).ToList();

            if (list2.Count() % 2 == 0)
            {
                var index1 = list2.Count() / 2;
                double val = ((Convert.ToDouble(list2[index1 - 1]) + Convert.ToDouble(list2[index1])) / 2);
                return val;
            }
            else
            {
                var index1 = list2.Count() / 2;
                return list2[index1];
            }
        }
        public IList<IList<int>> ThreeSum(int[] arr)
        {
            IList<IList<int>> bigList = new List<IList<int>>();
            if (arr.Length <= 2) return bigList;
            HashSet<List<int>> set = new HashSet<List<int>>();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        if (i != j && i != k && j != k)
                        {
                            if (arr[i] + arr[j] + arr[k] == 0)
                            {
                                List<int> smallList = new List<int>
                                    {
                                        arr[i],
                                        arr[j],
                                        arr[k]
                                    }.OrderBy(c => c).ToList();
                                var xxx = smallList.MinBy(x => Math.Abs(x - 5));
                                if (!IsContain(set, smallList))
                                {
                                    set.Add(smallList);
                                    bigList.Add(smallList);
                                }
                            }
                        }
                    }
                }
            };
            return bigList;
        }

        private bool IsContain(HashSet<List<int>> set, List<int> smallList)
        {
            var result = set.FirstOrDefault(c => c[0] == smallList[0]
                && c[1] == smallList[1]
                && c[2] == smallList[2]);
            return result != null && result.Count > 0;
        }
    }
}
