using System.Collections.Generic;
using System.Linq;

namespace MyDataStructure.Queue
{
    public class Node<T>
    {
        public T data { get; set; }
        public Node<T> next { get; set; }

    }

    public class MyQueue<T>
    {
        private Node<T> head;

        public List<Node<T>> GetAllNodes()
        {
            Node<T> current = head;
            var list = new List<Node<T>>();

            while (current != null)
            {
                list.Add(current);
                current = current.next;
            }

            return list;
        }

        public void Enqueue(T data) 
        {
            var node = new Node<T> {
                data = data,
            };

            if (head == null) {
                head = node;
                head.next = null;
            }
            else 
            {
                var current = node;

                current.next = head;
                head = node;
            }
        }

        public Node<T> Dequeue() 
        {

            if (head == null) {
                return null;
            }
            else 
            {
                var current = head;
                Node<T> previous = null;

                while (current.next != null)
                {
                    previous = current;
                    current = current.next;
                }

                if (previous == null) 
                    head = null;
                else
                    previous.next = null;

                return current;
                    
            }
        }

        public Node<T> GetNodeByValue(T data) 
        {
            Node<T> current = head;
            Node<T> selectedNode = null;

            while (current != null)
            {
                T currentData = current.data;

                if (currentData.Equals(data)) 
                {
                    selectedNode = current;
                }

                current = current.next;
            }

            return selectedNode;
        }

        public int GetNodeIndexByValue(T data) 
        {
            Node<T> current = head;
            int index = 0;

            while (current != null)
            {
                T currentData = current.data;

                if (currentData.Equals(data)) 
                    break;

                current = current.next;
                index++;
            }

            return index;
        }

        public void Clear() 
        {
            head = null;
        }
        public int Count() 
        {
            Node<T> current = head;
            int count = 0;

            while (current != null)
            {
                current = current.next;
                count++;

            }

            return count;
        }
    }
}