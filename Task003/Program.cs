// Задача 3: 
// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.


using System;

class Program
{
    static void Main()
    {
        int rows = 3;
        int columns = 4;

        int[,] array = new int[rows, columns];

        Random random = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = random.Next(1, 10); 
            }
        }

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        int minSumRow = FindMinSumRow(array);

        Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRow + 1}");
    }

    static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    static int FindMinSumRow(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        int minSum = int.MaxValue;
        int minSumRow = 0;

        for (int i = 0; i < rows; i++)
        {
            int currentSum = 0;
            for (int j = 0; j < columns; j++)
            {
                currentSum += array[i, j];
            }

            if (currentSum < minSum)
            {
                minSum = currentSum;
                minSumRow = i;
            }
        }

        return minSumRow;
    }
}