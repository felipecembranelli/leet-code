using System.Collections;

namespace MyDataStructure.Matrix
{
    public class MyArrayList
    {
        // create simple array list
        public int Get5ElementArraySize() 
        {
            var arr = new ArrayList();

            arr.Add("element1");
            arr.Add("element2");
            arr.Add("element3");
            arr.Add("element4");
            arr.Add(10);

            return arr.Count;

        }

        // create simple array list and resize it based on increase size parameter
        public int ResizeArrayList(int increaseSize) 
        {
            var arr = new ArrayList();

            arr.Add("element1");
            arr.Add("element2");
            arr.Add("element3");
            arr.Add("element4");
            arr.Add(10);

            var currentSize = arr.Count;

            for (int i = 1; i <= increaseSize; i++)
            {
                currentSize += i;
                arr.Add("new-element" + currentSize.ToString());
            }

            return arr.Count;

        }

        // create simple array and resize it based on increase size parameter
        public int ResizeArray(int increaseSize) 
        {
            int[] a1 = {1, 2, 3, 4, 5};

            var originalSize = a1.Length;

            System.Array.Resize(ref a1, originalSize + increaseSize);   // resize array, copying elements

            var newSize = a1.Length;

            for (int i = 1; i <= increaseSize; i++) {
                a1[originalSize] = originalSize + 1;
                originalSize++;
            }

            return a1.Length;
        }
    }
}