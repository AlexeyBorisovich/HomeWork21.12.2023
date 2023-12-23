// Задача 2: 
// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.


using System;

class Program
{
    static void Main()
    {
        int rows = 3;
        int cols = 4;

        int[,] array = new int[rows, cols];

        int value = 22;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = value;
                value++;
            }
        }

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        SwapRows(array, 0, rows - 1);

        Console.WriteLine("\nМассив после замены:");
        PrintArray(array);
    }

    static void PrintArray(int[,] arr)
    {
        int rows = arr.GetLength(0);
        int cols = arr.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void SwapRows(int[,] arr, int row1, int row2)
    {
        int cols = arr.GetLength(1);

        for (int j = 0; j < cols; j++)
        {
            int temp = arr[row1, j];
            arr[row1, j] = arr[row2, j];
            arr[row2, j] = temp;
        }
    }
}
