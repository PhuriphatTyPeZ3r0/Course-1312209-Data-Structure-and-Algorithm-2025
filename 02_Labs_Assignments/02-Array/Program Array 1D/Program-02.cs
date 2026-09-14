using System;

class SearchExampple
{
    static void Main()
    {
        int[] MyArray = { 5, 2, 8, 1, 9 };
        int target = 15;
        int index = -1;

        for (int i = 0; i < MyArray.Length; i++)
        {
            if (MyArray[i] == target)
            {
                index = i;
                break;
            }
        }
        if (index != -1)
        {
            Console.WriteLine("Found the value " + target + " at index " + index);
        }
        else
        {
            Console.WriteLine("No value found " + target);
        }
    }
}