using System;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int [,]array () {
    int [,] myArray = new int [,]{
        {1, 4, 7, 2},
        {5, 9, 2, 3},
        {8, 4, 2, 4},
    };
    return myArray;
}

int[,] sortingArray(int[,] array){
   // int [,] sortArray = new int [array.GetLength(0), array.GetLength(1)];
    int max = 0;
    int number = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
       
        for (int j = 0; j < array.GetLength(1); j++)
        {
            max = array[i,j];
            number = array[i,j];
            for (int l = j; l < array.GetLength(1); l++)
            {
                //Console.WriteLine($"{i}.{j}.{l} {array[i,l]}");
                if (array[i,l] > max){
                max = array[i,l];
                number = array[i,j];
                array[i,j] = max;
                
                array[i,l] = number; 
                }
            }
        }
    }
    return array;
 }

 void printArray ( int[,] array) {
    for (int i = 0; i< array.GetLength(0); i++)
    {
        Console.WriteLine("");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
    }
 }
  int [,] newArray = array();
  int [,] mySort = sortingArray(newArray); 
 printArray(mySort);