using System;

namespace MyDataStructure.Matrix
{
    public class Matrix
    {
        public static int[] Create1DMatrix(int[] values)
        {
            {
                int i, j;
                int[] arr1 = values;
                int size = values.Length;

                Console.Write("\n\nRead a 1D array of size " + size.ToString() + " and print the matrix :\n");
                Console.Write("------------------------------------------------------\n");

                /* Stored values into the array*/
                Console.Write("Input elements in the matrix :\n");
                for (i = 0; i < size; i++)
                {
                    Console.Write("element - [{0}] : ", i);
                    arr1[i] = values[i];
                }

                Console.Write("\nThe matrix is : \n");
                for (i = 0; i < size; i++)
                {
                    Console.Write("{0}\t", arr1[i]);
                }
                Console.Write("\n\n");

                return arr1;
            }
        }
        public static int[,] Create2DMatrix(int[,] values)
        {
            {
                int i, j;
                int count = 0;
                int numberRows = values.GetLength(0);
                int numberColumns = values.GetLength(1);

                int[,] arr1 = new int[numberRows, numberColumns];

                Console.Write("\n\nRead a 2D array of size " + numberRows.ToString() + "x" + numberColumns.ToString() + " and print the matrix :\n");
                Console.Write("------------------------------------------------------\n");

                /* Stored values into the array*/
                Console.Write("Input elements in the matrix :\n");
                for (i = 0; i < numberRows; i++)
                {
                    for (j = 0; j < numberColumns; j++)
                    {
                        Console.Write("element - [{0},{1}] : ", i, j);
                        arr1[i, j] = values[i,j];
                        count++;
                    }
                }

                Console.Write("\nThe matrix is : \n");
                for (i = 0; i < numberRows; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < numberColumns; j++)
                        Console.Write("{0}\t", arr1[i, j]);
                }
                Console.Write("\n\n");

                return arr1;
            }
        }
    }
}