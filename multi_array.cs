
using System;

class Program
{
    static void Main()
    {
        
        int[,,] numbers = new int[2, 2, 2]
        {
            {
                {1, 2},
                {3, 4}
            },
            {
                {5, 6},
                {7, 8}
            }
        };

        // Display the elements
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                for (int k = 0; k < numbers.GetLength(2); k++)
                {
                    Console.WriteLine($"numbers[{i},{j},{k}] = {numbers[i,j,k]}");
                }
            }
        }
    }
}
