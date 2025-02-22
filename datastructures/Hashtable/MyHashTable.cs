using System;

namespace MyDataStructure.Hash
{
    public class Node
    {
        public object Key { get; set; }
        public object Value { get; set; }
        public Node Next { get; set; }
        public Node Previous { get; set; }
    }

    public class Hashtable
    {
        private Node[] universe;
        private readonly int tableSize;

        public Hashtable(int maxTableSize)
        {
            tableSize = maxTableSize;
            universe = new Node[tableSize];
        }

        private int HashFunction(object key)
        {
            int index = 7;
            int asciiVal = 0;

            for (int i = 0; i < key.ToString().Length; i++)
            {
                asciiVal = (int)key.ToString()[i] * i;
                index = index * 31 + asciiVal;
            }
            return index % tableSize;
        }
         
        public void Add(object key, object value)
        { 
            int genIndex = HashFunction(key);
            Node node = universe[genIndex];

            if (node == null)
            {
                universe[genIndex] = new Node() { Key = key, Value = value };
                return;
            }

            if (node.Key == key)
                throw new Exception("Can't use same key!");

            while (node.Next != null)
            {
                node = node.Next;
                if (node.Key == key)
                    throw new Exception("Can't use same key!");
            }

            Node newNode = new Node() { Key = key, Value = value, Previous = node, Next = null };
            node.Next = newNode;
        }
        public object GetValue(object key)
        { 
            int genIndex = HashFunction(key);

            Node node = universe[genIndex];

            while (node != null)
            {
                if (node.Key.ToString() == key.ToString())
                {
                    return node.Value;
                }
                node = node.Next;
            }

            throw new Exception("Don't have the key in hash!");
        }
    }
    
}