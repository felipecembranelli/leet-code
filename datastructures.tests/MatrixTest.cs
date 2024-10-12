using Xunit;
using MyDataStructure.Matrix;
using System.Collections.Generic;

namespace datastructure.tests
{
    public class MatrixTest
    {
        [Fact]
        public void Create_One_Dimension_Matrix_Should_Return_Correct_Bounderies()
        {
            // arrange
            const int dimension = 0;        // zero based dimension

            int[] values = {1,2,3,4};
            // act
            var arr = Matrix.Create1DMatrix(values);

            // assert
            Assert.Equal(0, arr.GetLowerBound(dimension));  // return index of lower bound
            Assert.Equal(3, arr.GetUpperBound(dimension));  // return index of upper bound
        }
        [Fact]
        public void Create_2_Dimension_Matrix()
        {
            // arrange 4 X 2

            int[,] values = {
                                {1,1},
                                {2,2},
                                {3,3},
                                {4,4}
                            };

            // act
            var arr = Matrix.Create2DMatrix(values);

            // assert
            Assert.True(true);
        }        

        [Fact]
        public void Create_2B_Dimension_Matrix()
        {
            // arrange 4 X 3
            int[,] values = {
                                {1,1,1},
                                {2,2,2},
                                {3,3,3},
                                {4,4,4}
                            };

            // act
            var arr = Matrix.Create2DMatrix(values);

            // assert
            Assert.True(true);
        }        
    }
}

