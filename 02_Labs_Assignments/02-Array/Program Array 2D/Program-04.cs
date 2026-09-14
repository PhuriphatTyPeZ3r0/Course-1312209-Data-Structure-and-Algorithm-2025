using System;

class Searching2D{
          static void Main(){
            int[,] arr = {
                    { 5, 2, 8 },
                    { 1, 9, 3 }
                };
            int target = 9;
            bool found = false;

        for(int i = 0; i < arr.GetLength(0); i++){
            for(int j = 0; j < arr.GetLength(1); j++){
                if (arr[i, j] == target){
                  Console.WriteLine($"Found the {target} value at location ({i},{j})");
                  found = true;
                }
            }
        }
        
          if (!found)
              Console.WriteLine("No value found" + target);
      }
}