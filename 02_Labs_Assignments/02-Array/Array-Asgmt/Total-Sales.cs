using System;
public class TotalSales
{
    public static void Main()
    {
        int yearCount = 2;
        int monthCount = 3;
        int weekCount = 4;
        int[,,] sales = new int[yearCount, monthCount, weekCount];
        int[] totalSalesPerYear = new int[yearCount];
        int grandTotal = 0;
        for (int year = 0; year < yearCount; year++)
        {
            Console.WriteLine($"\nEnter sales data for Year {year + 1}:");
            int yearlyTotal = 0;
            for (int month = 0; month < monthCount; month++)
            {
                Console.WriteLine($"  Month {month + 1}:");
                for (int week = 0; week < weekCount; week++)
                {
                    Console.Write($"    Week {week + 1} sales: ");
                    sales[year, month, week] = Convert.ToInt32(Console.ReadLine());
                    yearlyTotal += sales[year, month, week];
                }
            }
            totalSalesPerYear[year] = yearlyTotal;
            grandTotal += yearlyTotal;
        }

        Console.WriteLine("\nTotal sales per year:");
        for (int year = 0; year < yearCount; year++)
        {
            Console.WriteLine($"Year {year + 1}: {totalSalesPerYear[year]}");
        }
        Console.WriteLine($"\nGrand Total Sales: {grandTotal}");

    }
}