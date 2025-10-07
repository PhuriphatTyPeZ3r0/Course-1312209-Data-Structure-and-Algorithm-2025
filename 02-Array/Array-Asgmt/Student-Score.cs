using System;
public class StudentScore
{
    public static void Main()
    {
        int studentCount = 3;
        int subjectCount = 4;

        int[,] scores = new int[studentCount, subjectCount];
        int[] totalScores = new int[studentCount];

        for (int i = 0; i < studentCount; i++)
        {
            Console.WriteLine($"\nEnter scores for Student {i + 1}:");
            int sum = 0;
            for (int j = 0; j < subjectCount; j++)
            {
                Console.Write($"  Subject {j + 1}: ");
                scores[i, j] = Convert.ToInt32(Console.ReadLine());
                sum += scores[i, j];
            }
            totalScores[i] = sum;
        }

        Console.WriteLine("\nStudent Scores and Total:");
        for (int i = 0; i < studentCount; i++)
        {
            Console.Write($"Student {i + 1}: ");
            for (int j = 0; j < subjectCount; j++)
            {
                Console.Write(scores[i, j] + " ");
            }
            Console.WriteLine($"| Total: {totalScores[i]}");
        }
    }
}