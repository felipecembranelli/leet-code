using MyDataStructure.Matrix;
using Xunit;

namespace datastructure.tests
{
    public class ArrayListTest
    {
        [Fact]
        public void Create_ArrayList_Should_Return_Size()
        {
            // arrange
            var arr = new MyArrayList();

            // act
            var count = arr.Get5ElementArraySize();

            // assert
            Assert.Equal(5, count);
            
        }

        [Fact]
        public void Resize_ArrayList_Should_Return_New_Size()
        {
            // arrange
            var arr = new MyArrayList();

            // act
            var count = arr.ResizeArrayList(5);

            // assert
            Assert.Equal(10, count);
        }

        [Fact]
        public void Resize_Array_Should_Return_New_Size()
        {
            // arrange
            var arr = new MyArrayList();

            // act
            var count = arr.ResizeArray(5);

            // assert
            Assert.Equal(10, count);
        }
        
    }
    
}