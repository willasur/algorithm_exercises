using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsTraining
{
    public class MyLinkedList
    {
        //public ListNode Head { get; set; }
       public class Node
        {
           public  int data;
           public Node next;
            private int val;

            public Node()
            {
            }

            public Node(int val)
            {
                this.val = val;
            }
        }
        Node head = null;
        Node tail = null;
        int size = 0;

 
        /** Initialize your data structure here. */
        public MyLinkedList()
        {
            head = new Node();
            tail = new Node();
            head.next = tail;
           //throw new NotImplementedException();
        }
 

        /** Get the val of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            if (index < 0 || index >= size)
                return -1;
            Node temp = head;
            for (int i = 0; i <= index; i++)
            {
                temp = temp.next;
            }
            return temp.data;
            //throw new NotImplementedException();
        }

        /** Add a node of val val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            AddAtIndex(0, val);
            //throw new NotImplementedException();
        }

        /** Append a node of val val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            AddAtIndex(size, val);
            //throw new NotImplementedException();
        }

        /** Add a node of val val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            if (index < 0 || index > size)
                return;
            Node temp = head;
            for (int i = 0; i < index; i++)
            {
                temp = temp.next;
            }
            Node k = new Node(val);
            k.next = temp.next;
            temp.next = k;
            size++;
            //throw new NotImplementedException();
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            throw new NotImplementedException();

        }
    }
}
