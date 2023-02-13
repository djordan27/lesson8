﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

void array()
{
    int n = 4;
    int m = 4;
    int[,] matrix = new int[n, m];

    int row = 0;
    int col = 0;
    int dx = 1;
    int dy = 0;
    int dirChanges = 0;
    int visits = m;

    for (int i = 0; i < matrix.Length; i++)
    {
        matrix[row, col] = i + 1;
        if (--visits == 0)
        {
            visits = m * (dirChanges % 2) + n * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }

        col += dx;
        row += dy;
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine("");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(string.Format("{0:d2}",matrix[i, j]) + " ");
        }
    }
}

array();
