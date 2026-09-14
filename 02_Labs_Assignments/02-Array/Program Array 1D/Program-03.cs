using System;

class InsertingExample
{
    static void Main()
    {
        int[] MyArray = { 5, 2, 8, 1, 9 };
        int value = 7;
        int position = 2;

        int[] NewArray = new int[MyArray.Length + 1];
        Console.Write("Array after insertion value: ");
        for (int i = 0, j = 0; i < NewArray.Length; i++)
        {
            if (i == position)
            {
                NewArray[i] = value;
            }
            else
            {
                NewArray[i] = MyArray[j++];
            }
            Console.Write(NewArray[i]);
        }
        
    }
}