using LinkedListProg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProg.Areas
{
    public class LinkedList
    {
        public static Node head = null;



        /// <summary>
        /// Traverse from head and print all nodes value
        /// </summary>

        public void PrintAllNodes()
        {
            //Traverse from head
            Console.Write("\n\r Head ->");
            Node curr = head;
            while (curr.next != null)
            {
                curr = curr.next;
                Console.Write(curr.data);
                Console.Write("->");
            }
            Console.Write("NULL");
        }

        internal Node RemoveDuplicates()
        {
            Node curr = head;
            Node prev = null;
            List<string> uniqueItemList = new List<string>();
            while (curr.next != null)
            {
                if (uniqueItemList.Contains((string)curr.data))
                {
                    prev.next = curr.next;
                }
                else
                {
                    uniqueItemList.Add((string)curr.data);
                    prev = curr;
                }
                curr = curr.next;
            }
            return head;
        }

        //public void PrintAllNodes()
        //{
        //    Node cur = head;
        //    while (cur.next != null)
        //    {
        //        Console.WriteLine(cur.data);
        //        cur = cur.next;
        //    }
        //}

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

        /// <summary>
        /// Print the reverse linked list
        /// </summary>
        /// <param name="k"></param>
        internal void PrintReverseList(int k)
        {
            head = Reverse(head, k);
        }

        /// <summary>
        /// Delete the node from the linked list
        /// </summary>
        /// <param name="position"></param>
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
            for (int i = 0; temp != null && i < (position - 1); i++)
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
}
