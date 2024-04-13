namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new LinkedList<string>();
            //insert
            var a = linkedList.AddLast("a");
            var b = linkedList.AddLast("b");
            var node = new LinkedListNode<string>("test");
            //insert in position
            linkedList.AddBefore(b, node);
            //remove
            linkedList.Remove("b");

            //remove before element
            linkedList.RemoveLast();
            linkedList.RemoveFirst();
            foreach (var item in linkedList)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}