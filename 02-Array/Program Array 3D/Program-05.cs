using System;
using System.Linq;

class Sorting3D{
      static void Main(){
              int[,,] arr = {
                  { { 5, 2 }, { 8, 1 } },
                  { { 9, 4 }, { 7, 6 } }
                };
              int depth = arr.GetLength(0);
              int rows = arr.GetLength(1);
              int cols = arr.GetLength(2);
 
              int[] flat = arr.Cast<int>().ToArray();
              Array.Sort(flat);
              int[,,] sorted = new int[depth, rows, cols];
              int index = 0;
            
            for(int i = 0; i < depth; i++)
              for(int j = 0; j < rows; j++)
                for(int k = 0; k < cols; k++)
                      sorted[i, j, k] = flat[index++];
                      Console.WriteLine("Array after sorting:");
                      Print3D(sorted);
            }

    static void Print3D(int[,,] arr){
          for (int i = 0; i < arr.GetLength(0); i++){
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