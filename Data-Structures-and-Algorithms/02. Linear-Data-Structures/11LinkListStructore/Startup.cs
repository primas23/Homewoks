using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11LinkListStructore
{
    public class Startup
    {
        public static void Main()
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.Add(5);
            linkedList.Add(4);
            linkedList.Add(15);

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
