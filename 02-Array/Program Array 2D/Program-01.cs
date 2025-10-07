using System;

class Traversing2D{
      static void Main(){
            int[,] arr = {
                { 5, 2, 8 },
                { 1, 9, 3 }
            };
        Console.WriteLine("Traversing with for:");
        
        for (int i = 0; i < arr.GetLength(0); i++){
          
              for (int j = 0; j < arr.GetLength(1); j++){
                    Console.Write(arr[i, j] + " ");
              }
          Console.WriteLine();
        }
      Console.WriteLine("\nTraversing with foreach:");

        foreach(int item in arr){
                Console.Write(item + " ");
        }
    }
}