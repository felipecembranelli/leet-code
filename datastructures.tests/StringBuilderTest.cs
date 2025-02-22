
using Xunit;

namespace datastructure.tests
{
    public class StringBuilderTest
    {
        [Fact]
        public void Append_Less_Than_Capacity_Test()
        {
            // arrange
            var sb = new MyDataStructure.String.SimpleStringBuilder(25);
            
            var s1 = "my string 1";
            var s2 = "my string 2";
            var exptectedStringResult = s1 + s2;

            // act
            sb.Append(s1);
            sb.Append(s2);
            
            // assert
            Assert.Equal(exptectedStringResult, sb.ToString());
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