using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm
{
    public class Test
    {
        public static void Main(string[] args)
        {
            MySinglyLinkedList list = new MySinglyLinkedList();
            list.AddAtHead(1);
            list.AddAtHead(2);
            list.AddAtHead(3);
            list.AddAtTail(4);
            Console.WriteLine(list.DeleteAtIndex(1));
        }
    }
}
