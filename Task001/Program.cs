
// Задача 1:
//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.


using System;

class Program
{
    static void Main()
    {
        int[,] array2D = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.WriteLine("Введите координаты элемента (строка и столбец):");
        
        Console.Write("Строка: ");
        int row = int.Parse(Console.ReadLine());

        Console.Write("Столбец: ");
        int col = int.Parse(Console.ReadLine());

        int result = GetArrayElement(array2D, row, col);
        if (result != int.MinValue)
        {
            Console.WriteLine($"Элемент [{row},{col}] = {result}");
        }
        else
        {
            Console.WriteLine($"Элемент [{row},{col}] отсутствует в массиве.");
        }
    }

    static int GetArrayElement(int[,] array, int row, int col)
    {
        int numRows = array.GetLength(0);
        int numCols = array.GetLength(1);

        if (row >= 0 && row < numRows && col >= 0 && col < numCols)
        {
            return array[row, col];
        }
        else
        {
            return int.MinValue;
        }
    }
}