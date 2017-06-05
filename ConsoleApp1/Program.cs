using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ashish.LinkedList
{

    public class Node
    {
        public Node next;
        public Object data;
    }


    public class LinkedList
    {
        public static Node head = null;

        public void PrintAllNodes()
        {
            Node cur = head;
            while (cur.next != null)
            {
                Console.WriteLine(cur.data);
                cur = cur.next;
            }
        }

        public void Add(Object data)
        {
            if (head == null)
            {
                head = new Node();

                head.data = data;
                head.next = null;
            }
            else
            {
                Node toAdd = new Node();
                toAdd.data = data;

                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = toAdd;
            }
        }

        internal Node Reverse(Node head, int k)
        {
            Node curr = head;
            Node next = null;
            Node prev = null;
            int count = 0;
            while (curr != null && count < k)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
                count++;
            }
            if (next != null)
            { head.next = Reverse(next, k); }

            return prev;
        }

        internal void PrintReverseList(int k)
        {
            head = Reverse(head, k);
        }

        internal void Delete(int position)
        {
            if (head == null)
            {
                return;
            }

            // store head node
            Node temp = head;

            // if head node is removed
            if (position == 0)
            {
                head = temp.next;
                return;
            }

            // find the previous node of the node to be deleted
            for (int i = 0; temp != null && i < position - 1; i++)
            {
                temp = temp.next;
            }

            // if position is more than number of nodes
            if (temp == null || temp.next == null)
            {
                return;
            }

            // Node temp->Next is the node to be deleted
            // Store pointer to the next of node to be deleted
            Node next = temp.next.next;
            temp.next = next; // Unlink the deleted node from list
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedlist = new LinkedList();
            linkedlist.Add("15");
            linkedlist.Add("85");
            linkedlist.Add("12");
            linkedlist.Add("41");
            linkedlist.Add("31");
            linkedlist.Add("53");
            linkedlist.Add("69");
            linkedlist.Add("44");
            linkedlist.Add("75");
            linkedlist.Add("69");
            linkedlist.Add("11");
            linkedlist.PrintAllNodes();

            Console.WriteLine("finish..");


            linkedlist.Delete(3);

            linkedlist.PrintAllNodes();


            linkedlist.PrintReverseList(3);
            linkedlist.PrintAllNodes();
            Console.ReadLine();

        }
    }
}
