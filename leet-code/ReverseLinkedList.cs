// See https://aka.ms/new-console-template for more information
using System;

// https://leetcode.com/problems/valid-anagram/
static class ReverseLinkedList {


    public static LinkedListNode Reverse(LinkedListNode head)
    {
        LinkedListNode p2 = head;
        //LinkedListNode head = p1;

        while (p2.Value < p2.Next.Value) 
        {
            if (p2.Value>head.Value)
                head = p2;
            
            p2 = p2.Next;
            
        }    

        return head;
    }
   
}

public class LinkedList {

    LinkedListNode head;
    List<object> list = new List<object>();

    public void AddNode(int data) {

        var node = new LinkedListNode(data);
            
        if (head== null) {
            head = node;
            head.Next = null;
        }
        else {
            var current = head;

            while (current.Next!=null)
                current = current.Next;

            current.Next = node;

        }
        list.Add(node);
    }

    public List<object> GetAllNodes() {

        return list;
    }

    public List<object> GetAllNodes2() {

        LinkedListNode current = head;
        var list = new List<object>();

        while (current!=null) {

            list.Add(current);
            current = current.Next;
        }

        return list;
    }

}

public class LinkedListNode {
    public int Value { get; set; }
    public LinkedListNode Next  {get;set;}

    public LinkedListNode(int value) {
        this.Value = value;
    }


}