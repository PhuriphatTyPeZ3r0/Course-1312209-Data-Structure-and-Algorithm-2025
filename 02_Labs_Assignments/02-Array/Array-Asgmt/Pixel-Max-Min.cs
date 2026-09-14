using System;
public class PixelMaxMin
{
    public static void Main()
    {
        int pixelrowscount = 3;
        int pixelcolumcount = 3;
        int[,] grayscale = new int[pixelrowscount, pixelcolumcount];

        for (int i = 0; i < pixelrowscount; i++)
        {
            for (int j = 0; j < pixelcolumcount; j++)
            {
                Console.Write($"Enter pixel value at [{i},{j}]: ");
                grayscale[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        int max = grayscale[0, 0];
        int min = grayscale[0, 0];
        int sum = 0;

        for (int i = 0; i < pixelrowscount; i++)
        {
            for (int j = 0; j < pixelcolumcount; j++)
            {
                int val = grayscale[i, j];
                if (val > max) max = val;
                if (val < min) min = val;
                sum += val;
            }
        }

        double avg = sum / (double)(pixelrowscount * pixelcolumcount);

        Console.WriteLine($"Max pixel value: {max}");
        Console.WriteLine($"Min pixel value: {min}");
        Console.WriteLine($"Average pixel value: {avg:F2}");
    }
}