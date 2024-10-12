using System;
using Xunit;

namespace datastructure.tests
{
    public class QueueTest
    {
        [Fact]
        public void Enqueue_Object_Should_Get_Correct_List_Count()
        {
            //arrange
            MyDataStructure.Queue.MyQueue<string> queue = new MyDataStructure.Queue.MyQueue<string>();

            //act
            queue.Enqueue("obj1");
            queue.Enqueue("obj2");
            queue.Enqueue("obj3");
            queue.Enqueue("obj4");

            //assert
            Assert.Equal(4, queue.GetAllNodes().Count);

        }

        [Fact]
        public void Dequeue_Object_Should_Return_first_element()
        {
            //arrange
            MyDataStructure.Queue.MyQueue<string> queue = new MyDataStructure.Queue.MyQueue<string>();

            //act
            queue.Enqueue("obj1");
            queue.Enqueue("obj2");
            queue.Enqueue("obj3");
            queue.Enqueue("obj4");

            var node1 = queue.Dequeue();
            var node2 = queue.Dequeue();
            var node3 = queue.Dequeue();
            var node4 = queue.Dequeue();
            var node5 = queue.Dequeue();

            //assert
            Assert.Equal("obj1", node1.data.ToString());
            Assert.Equal("obj2", node2.data.ToString());
            Assert.Equal("obj3", node3.data.ToString());
            Assert.Equal("obj4", node4.data.ToString());
            Assert.Null(node5);

        }
    }
}
