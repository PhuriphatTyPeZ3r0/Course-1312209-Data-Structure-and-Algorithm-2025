using System;

class Deleting2D{
        static void Main(){
                int[,] arr = {
                  { 5, 2, 8 },
                  { 1, 9, 3 },
                  { 4, 6, 7 }
                  };
                int deletePos = 1;  
                int rows = arr.GetLength(0);
                int cols = arr.GetLength(1);
                int[,] newArr = new int[rows - 1, cols];

            for (int i = 0, k = 0; i < rows; i++){
                if (i == deletePos) continue;
                  for (int j = 0; j < cols; j++)
                      newArr[k, j] = arr[i, j];
                      k++;
                }
              Console.WriteLine("Array after deleting rows:");
              Print2D(newArr);
            }

      static void Print2D(int[,] arr){
          for (int i = 0; i < arr.GetLength(0); i++){
            for (int j = 0; j < arr.GetLength(1); j++)
                Console.Write(arr[i, j] + " ");
                Console.WriteLine();
            }
          }
}