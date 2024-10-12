using System.Collections.Generic;
using System.Linq;

namespace MyDataStructure
{
    public class Node<T>
    {
        public T data { get; set; }
        public Node<T> next { get; set; }

    }

    public class LinkedList<T>
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

        public void AddLast(T data) 
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
                var current = head;

                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = node;
            }
        }

        public void AddFirst(T data) 
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

        public void AddBefore(Node<T> node, T data) 
        {
            Node<T> current = head;
            Node<T> previous = null;

            while (current != null)
            {
                if (current.data.Equals(data)) 
                {
                    previous.next = node;
                    node.next = current;

                    return;
                }
                else 
                {
                    previous = current;
                    current = current.next;
                }
            }
        }

        public void AddAfter(Node<T> node, T data) 
        {
            Node<T> current = head;

            while (current != null)
            {
                if (current.data.Equals(data)) 
                {
                    node.next = current.next;
                    current.next = node;

                    return;
                }
                else 
                {
                    current = current.next;
                }
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