using System;

class Program
{
    static void Main()
    {
        // Declare a jagged array
        int[][] numbers = new int[3][];

        // Initialize each row with different sizes
        numbers[0] = new int[] { 10, 20 };
        numbers[1] = new int[] { 30, 40, 50 };
        numbers[2] = new int[] { 60, 70, 80, 90 };

        // Display the elements
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers[i].Length; j++)
            {
                Console.Write(numbers[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}
