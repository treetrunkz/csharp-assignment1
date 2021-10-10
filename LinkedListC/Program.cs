using System;
using System.Collections.Generic;
namespace LinkedListC
{
    public class Node
    {
        public Node next;
        public Object data;
    }

    public class ADTLinkedList
    {
        private Node head;

        public void printAllNodes()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public void Add(Object data)
        {
            Node add = new Node();
            add.data = data;
            add.next = head;
            head = add;
        }
    }

    class Program
    {
        static public void Main(string[] args)
        {
            Console.WriteLine("Native LinkedList");
            LinkedList<String> my_list = new LinkedList<String>();
            my_list.AddLast("One");
            my_list.AddLast("Two");
            my_list.AddLast("Three");
            my_list.AddLast("Four");
            my_list.AddLast("Five");

            foreach(string str in my_list)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("ADT LinkedList");
            ADTLinkedList list = new ADTLinkedList();

            list.Add("Hi");
            list.Add(",");
            list.Add("May I help you?");

            list.printAllNodes();
            Console.ReadLine();
        }

    }
}
