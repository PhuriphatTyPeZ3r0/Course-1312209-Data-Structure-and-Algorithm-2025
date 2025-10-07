using System;

class Traversing3D{
      static void Main(){
             int[,,] arr = {
                {{ 1, 2, 3 }, { 4, 5, 6 }},
                {{ 7, 8, 9 }, { 10, 11, 12 }}
               };
     Console.WriteLine("Traversing array 3D:");

        for (int i = 0; i < arr.GetLength(0); i++){
            for (int j = 0; j < arr.GetLength(1); j++){
                for (int k = 0; k < arr.GetLength(2); k++){
                  Console.Write($"arr[{i},{j},{k}] = {arr[i,j,k]} ");
                }
              Console.WriteLine();
            }
          Console.WriteLine();
        }
    }
}