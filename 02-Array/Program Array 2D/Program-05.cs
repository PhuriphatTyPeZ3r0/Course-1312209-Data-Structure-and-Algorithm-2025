using System;

class Sorting2D{
          static void Main(){
              int[,] arr = {
                 { 5, 2, 8 },
                 { 1, 9, 3 }
               };

            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);
            int[] flat = new int[rows * cols];
            int k = 0;

      foreach(int item in arr) flat[k++] = item;
                Array.Sort(flat);
                k = 0;
                int[,] sorted = new int[rows, cols];
            for(int i = 0; i < rows; i++)
                for(int j = 0; j < cols; j++)
                      sorted[i, j] = flat[k++];
                      Console.WriteLine("Array after sorting:");
                      Print2D(sorted);
          }
          
  static void Print2D(int[,] arr){
    for(int i = 0; i < arr.GetLength(0); i++){
        for(int j = 0; j < arr.GetLength(1); j++)
              Console.Write(arr[i, j] + " ");
              Console.WriteLine();
    }
  }
}