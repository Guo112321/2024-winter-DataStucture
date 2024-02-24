//This problem worthy of 10%
using System.Diagnostics;
using System.Xml.Linq;

public class ListNode
{
    public int Val;
    public ListNode Next;

    public ListNode(int val = 0, ListNode next = null)
    {
        Val = val;
        Next = next;
    }
}

public class MySinglyLinkedList
{
    private ListNode head;

    public MySinglyLinkedList()
    {
        head = null;
    }

    public void AddAtHead(int val)
    {
        // TODO: Complete the AddAtHead method to add a node with the given value at the beginning of the list
        ListNode newNode = new ListNode(val); 
        newNode.Next = head;
        head = newNode;
    }

    public void AddAtTail(int val)
    {
        // TODO: Complete the AddAtTail method to add a node with the given value at the end of the list
        ListNode newNode = new ListNode(val); ;

        if (head == null)
        {
            head = newNode;
            return;
        }

        ListNode currendNode = head;
        while (currendNode.Next != null)
        {
            currendNode = currendNode.Next;
        }

        currendNode.Next = newNode;
    }

    public int DeleteAtIndex(int index)
    {
        // TODO: Complete the DeleteAtIndex method to delete the node at the given index in the list and return its value
        ListNode currentNode = head;
        int result = -1;

        if (head == null) 
        {
            Console.WriteLine("list is empty");
            return result;
        }

        if (index == 0)
        {
            result = head.Val;
            head = currentNode.Next;
            return result;
        }


        int i = 0;
        while (i != index - 1)
        {
            
            currentNode = currentNode.Next;

            if (currentNode.Next == null)
            {
                Console.WriteLine("index is more than the count of list");
                return result;
            }
            i++;
        }
        result = currentNode.Next.Val;
        currentNode.Next = currentNode.Next.Next;
        return result;


    }
}
