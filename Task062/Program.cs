    // Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
    // Например, на выходе получается вот такой массив:
    // 01 02 03 04
    // 12 13 14 05
    // 11 16 15 06
    // 10 09 08 07

    //================================================

using System;
 class Program
{
    static void Main()
    {
        int n = 4;
        int[,] array = new int[n, n];
         int value = 1;
        int startX = 0;
        int startY = 0;
        int endX = n - 1;
        int endY = n - 1;
         while (value <= n * n)
        {
            // Вправо
            for (int i = startX; i <= endX; i++)
            {
                array[startY, i] = value++;
            }
            startY++;
             // Вниз
            for (int i = startY; i <= endY; i++)
            {
                array[i, endX] = value++;
            }
            endX--;
             // Влево
            for (int i = endX; i >= startX; i--)
            {
                array[endY, i] = value++;
            }
            endY--;
             // Вверх
            for (int i = endY; i >= startY; i--)
            {
                array[i, startX] = value++;
            }
            startX++;
        }
         // Выводим массив
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{array[i, j]:D2} ");
            }
            Console.WriteLine();
        }
         Console.ReadLine();
    }
}