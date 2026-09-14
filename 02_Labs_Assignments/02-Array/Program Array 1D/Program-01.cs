using System;
class TraversingExample
{
    public static void Run()
    {
        int[] MyArray = { 5, 2, 8, 1, 9 };
        Console.Write("TraversingExample with for: ");
        for (int i = 0; i < MyArray.Length; i++)
        {
            Console.Write(MyArray[i] + " ");
        }
        Console.Write("\nTraversingExample with foreach: ");
        foreach (int item in MyArray)
        {
            Console.Write(item + " ");
        }
    }
}