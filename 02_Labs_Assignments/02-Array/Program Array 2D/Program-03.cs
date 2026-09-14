using System;

class Inserting2D{
      static void Main(){
            int[,] arr = {
                  { 5, 2, 8 },
                  { 1, 9, 3 }
                };
            int[] newRow = { 7, 7, 7 };
            int insertPos = 1;  
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);
            int[,] newArr = new int[rows + 1, cols];

      for (int i = 0, k = 0; i < newArr.GetLength(0); i++){
            if (i == insertPos){
              for (int j = 0; j < cols; j++)
                  newArr[i, j] = newRow[j];
            }else{

              for (int j = 0; j < cols; j++)
                  newArr[i, j] = arr[k, j];
                  k++;
            }
      }

      Console.WriteLine("Array After inserting a new row:");
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