using System.Collections.Generic;
using System.Linq;

namespace MyDataStructure
{
    public class DNode<T>
    {
        public T data { get; set; }
        public DNode<T> next { get; set; }
        public DNode<T> prev { get; set; }

    }

    public class DoubleLinkedList<T>
    {
        private DNode<T> head;

        public List<DNode<T>> GetAllNodes()
        {
            DNode<T> current = head;
            var list = new List<DNode<T>>();

            while (current != null)
            {
                list.Add(current);
                current = current.next;
            }

            return list;
        }

        public void AddLast(T data) 
        {
            var node = new DNode<T> {
                data = data,
            };

            if (head == null) {
                head = node;
                head.next = null;
                head.prev = null;
            }
            else 
            {
                var current = head;

                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = node;
                node.prev = current;
            }
        }

        public void AddFirst(T data) 
        {
            var node = new DNode<T> {
                data = data,
            };

            if (head == null) {
                head = node;
                head.next = null;
                head.prev = null;
            }
            else 
            {
                var current = node;

                current.next = head;
                current.prev = null;
                head = node;
            }
        }

        public void AddBefore(DNode<T> node, T data) 
        {
            DNode<T> current = head;
            DNode<T> previous = null;

            while (current != null)
            {
                if (current.data.Equals(data)) 
                {
                    previous.next = node;
                    node.next = current;
                    current.prev = node;
                    node.prev = previous;

                    return;
                }
                else 
                {
                    previous = current;
                    current = current.next;
                }
            }
        }

        public void AddAfter(DNode<T> node, T data) 
        {
            DNode<T> current = head;

            while (current != null)
            {
                if (current.data.Equals(data)) 
                {
                    node.next = current.next;
                    current.next = node;
                    node.prev = current;
                    current.next.prev = node;

                    return;
                }
                else 
                {
                    current = current.next;
                }
            }
        }
        public DNode<T> GetNodeByValue(T data) 
        {
            DNode<T> current = head;
            DNode<T> selectedNode = null;

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
            DNode<T> current = head;
            int index = 0;

            while (current != null)
            {
                T currentData = current.data;

                if (!currentData.Equals(data)) 
                {
                    current = current.next;
                    index++;
                }
            }

            return index;
        }

        public void Clear() 
        {
            head = null;
        }
        public int Count() 
        {
            DNode<T> current = head;
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