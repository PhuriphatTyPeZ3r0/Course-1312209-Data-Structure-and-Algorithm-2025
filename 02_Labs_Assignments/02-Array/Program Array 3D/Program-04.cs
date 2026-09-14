using System;

class Searching3D{
      static void Main(){
                int[,,] arr = {
                    { { 1, 2, 3 }, { 4, 5, 6 } },
                    { { 7, 8, 9 }, { 10, 11, 12 } }
                  };
            int target = 9;
            bool found = false;
        
            for (int i = 0; i < arr.GetLength(0); i++){
                  for (int j = 0; j < arr.GetLength(1); j++){
                    for (int k = 0; k < arr.GetLength(2); k++){
                          if (arr[i, j, k] == target){
                                Console.WriteLine($"Found the {target} value at location ({i},{j},{k})");
                                found = true;
                          }
                    }
                  }
            }
        if (!found)
            Console.WriteLine($"No value found {target}");
    }
}