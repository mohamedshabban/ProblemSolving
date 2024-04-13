namespace Easy
{
    public class ReverseList
    {
        public static List<int> reverseArray(List<int> list)
        {
            var reverseList = new List<int>();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                reverseList.Add(list[i]);
            }
            return reverseList;
        }
    }

}
