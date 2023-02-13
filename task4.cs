// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

*/
int [,,]array () {
    int [,,] myArray = new int [,,]
    {{{66, 27}, {25,90}}, {{34,26}, {41,55}}};
    return myArray;
}
 void printArray ( int[,,] array) {
    for (int i = 0; i< array.GetLength(0); i++)
    {
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
            Console.Write($"{array[j,l,i]}({j},{l},{i}) ");    
            }
            Console.WriteLine("");
        }
    }
 }
 printArray(array());