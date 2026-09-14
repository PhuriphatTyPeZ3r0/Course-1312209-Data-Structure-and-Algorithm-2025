using System;
public class VideoValue
{
    public static void Main()
    {
        int framecount = 2;
        int framerowcount = 2;
        int framecolumcount = 3;

        int[,,] video = new int[framecount, framerowcount, framecolumcount];

        for (int f = 0; f < framecount; f++)
        {
            Console.WriteLine($"Frame {f + 1}:");
            for (int r = 0; r < framerowcount; r++)
            {
                for (int c = 0; c < framecolumcount; c++)
                {
                    Console.Write($"  Pixel [{r},{c}]: ");
                    video[f, r, c] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        int totalSum = 0;
        for (int f = 0; f < framecount; f++)
        {
            for (int r = 0; r < framerowcount; r++)
            {
                for (int c = 0; c < framecolumcount; c++)
                {
                    totalSum += video[f, r, c];
                }
            }
        }

        Console.WriteLine($"\nTotal sum of all pixels in all frames: {totalSum}");

        for (int f = 0; f < framecount; f++)
        {
            int frameSum = 0;
            for (int r = 0; r < framerowcount; r++)
            {
                for (int c = 0; c < framecolumcount; c++)
                {
                    frameSum += video[f, r, c];
                }
            }
            double frameAvg = frameSum / (double)(framerowcount * framecolumcount);
            Console.WriteLine($"Average pixel value for Frame {f + 1}: {frameAvg:F2}");
        }
    }
}