using System;

namespace _11LinkListStructore
{
    public class Startup
    {
        public static void Main()
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);

            Console.WriteLine(linkedList.FirstElement);
            Console.WriteLine(linkedList.FirstElement.NextItem);
            Console.WriteLine(linkedList.FirstElement.NextItem.NextItem);

            foreach (int item in linkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
