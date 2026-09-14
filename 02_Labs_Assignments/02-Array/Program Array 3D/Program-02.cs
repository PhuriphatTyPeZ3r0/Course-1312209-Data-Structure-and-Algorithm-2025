using System;

class Inserting3D{
        static void Main(){
                int[,,] arr = {
                    { { 1, 2 }, { 3, 4 } },
                    { { 5, 6 }, { 7, 8 } }
                  };
                int[ , ] newLayer = { { 9, 9 }, { 9, 9 } };  
                int insertPos = 1;  
                int depth = arr.GetLength(0);
                int rows = arr.GetLength(1);
                int cols = arr.GetLength(2);
                int[,,] newArr = new int[depth + 1, rows, cols];
            
              for(int i = 0, d = 0; i < newArr.GetLength(0); i++){
                  if(i == insertPos){
                    for(int j = 0; j < rows; j++)
                      for(int k = 0; k < cols; k++)
                          newArr[i, j, k] = newLayer[j, k];
                  }else{
                        for(int j = 0; j < rows; j++)
                          for(int k = 0; k < cols; k++)
                              newArr[i, j, k] = arr[d, j, k];
                              d++;
                  }
                }
          Console.WriteLine("Array after inserting new layer:");
          Print3D(newArr);
        }
        
  static void Print3D(int[,,] arr){
      for(int i = 0; i < arr.GetLength(0); i++){
            Console.WriteLine($"Layer {i}:");
        for(int j = 0; j < arr.GetLength(1); j++){
          for(int k = 0; k < arr.GetLength(2); k++)
              Console.Write(arr[i, j, k] + " ");
              Console.WriteLine();
        }
      Console.WriteLine();
      }
    }
}