
using Xunit;

namespace datastructure.tests
{
    public class StackTest
    {
        [Fact]
        public void Push_Less_Than_Capacity()
        {
            // arrange
            var stack = new MyDataStructure.Stack.SimpleStack();
            
            var s1 = "my string 1";
            var s2 = "my string 2";

            // act
            stack.Push(s1);
            stack.Push(s2);
            
            // assert
            Assert.Equal(2, stack.Count());
        }

         [Fact]
        public void Push_More_Than_Capacity()
        {
            // arrange
            var stack = new MyDataStructure.Stack.SimpleStack();
            
            // act
            for (int i = 0; i < 100; i++)
            {
                var s = "my string " + i.ToString();

                stack.Push(s);
            }
            
            // assert
            Assert.Equal(100, stack.Count());
        }


        [Fact]
        public void Pop_Should_Return_Top_Element()
        {
            // arrange
            var stack = new MyDataStructure.Stack.SimpleStack();
            
            var s1 = "my string 1";
            var s2 = "my string 2";

            // act
            stack.Push(s1);
            stack.Push(s2);
            var obj = stack.Pop();
            
            // assert
            Assert.Equal(s2, obj.ToString());
        }

        [Fact]
        public void Remove_All_Elements_Should_Return_Null()
        {
            // arrange
            var stack = new MyDataStructure.Stack.SimpleStack();
            
            var s1 = "my string 1";
            var s2 = "my string 2";

            // act
            stack.Push(s1);
            stack.Push(s2);

            var obj1 = stack.Pop();
            var obj2 = stack.Pop();
            var obj3 = stack.Pop();
            var obj4 = stack.Pop();
            
            // assert
            Assert.Null(obj4);
        }

        [Fact]
        public void Append_Greater_Than_Capacity_Test()
        {
            // arrange
            var sb = new MyDataStructure.String.SimpleStringBuilder(25);
            
            var s1 = "my long string 1";
            var s2 = "my long string 2";
            var exptectedStringResult = s1 + s2;

            // act
            sb.Append(s1);
            sb.Append(s2);
            
            // assert
            Assert.Equal(exptectedStringResult, sb.ToString());
        }

        [Fact]
        public void Clear_Should_Return_Empty_Strting()
        {
            // arrange
            var sb = new MyDataStructure.String.SimpleStringBuilder(25);
            
            var s1 = "my long string 1";
            var s2 = "my long string 2";

            // act
            sb.Append(s1);
            sb.Append(s2);
            sb.Clear();
            
            // assert
            Assert.Equal(string.Empty, sb.ToString());
        }
        
    }
    
}