// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

*/
int [,]array () {
    int [,] myArray = new int [,]{
        {1, 4, 7, 2},
        {5, 9, 2, 3},
        {8, 4, 2, 4},
        {5, 2, 6, 7}
    };
    return myArray;
}

void minString (int[,] array){
    int [] sum = new int[array.GetLength(0)];
    int count = 0;
    int min = 1000;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] += array[i,j];
        }
        //Console.WriteLine(sum[i]);
        if(min > sum[i]){
        min = sum[i];
        count = i+1;
        }
    }
    Console.WriteLine($"строка с наименьшей суммой элементов: {count}");
} 

int [,] newArray = array();
minString(newArray);