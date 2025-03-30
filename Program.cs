using System;
using System.Collections;


namespace ArraysContainer
{
    class MyArrays
    {
        public static void Main(string[] args)
        {
            TwoDimensionArray td = new TwoDimensionArray();
            //td.TwoArray();
            ThreeDimensionalArray td2 = new ThreeDimensionalArray();
            //td2.JaggedArray();
        }
    }
}

class OneDimensionalArray
{ 
    public void OneArray()
    {
        int[] arr = new int[10];
        int[] arr2 = new int[5] { 1, 2, 3, 4, 5 };
        int[] arr3 = { 4, 8, 7, 9, 8, 4 };

        foreach (int i in arr3)
        {
            Console.WriteLine(i);
        }

    }
}
class TwoDimensionArray
{
    int[,] arr = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
    public void TwoArray() {
        Console.WriteLine(arr[1, 2]);
    }
}

class ThreeDimensionalArray
{
    
    public void JaggedArray()
    {
        int[][] matrix = new int[3][];
        matrix[0]= new int[] {1,2}; 
        matrix[1]= new int[] {3,4,5};
        matrix[2] = new int[] { 6 };

        for(int i=0; i<matrix.Length; i++)
        {
            for(int j=0;  j<matrix[i].Length; j++)
            {
                Console.Write($"{matrix[i][j]} ");
            }
            Console.WriteLine();
        }

    }
}

class ArrayList
{
    public void GetArrayList()
    {
        ArrayList myList = new ArrayList();

        // Adding elements to ArrayList 
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);
        myList.Add(4);
        myList.Add(5);

        // Displaying count of elements of ArrayList 
        Console.WriteLine("Number of elements: " + myList.Count);

        // Displaying Current capacity of ArrayList 
        Console.WriteLine("Current capacity: " + myList.Capacity);
    }
    
    
}
