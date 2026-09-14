using System;       

class DeletingExample
{
    static void Main()
    {
        int[] MyArray = { 5, 2, 8, 1, 9 };
        int position = 2;

        int[] NewArray = new int[MyArray.Length - 1];
        Console.Write("Array after deletion value: ");
        for (int i = 0, j = 0; i < MyArray.Length; i++)
        {
            if (i == position)
            {
                continue;
            }
            NewArray[j++] = MyArray[i];
        }
        foreach (var item in NewArray)
        {
            Console.Write(item);
        }
    }
}