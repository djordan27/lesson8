// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
int [,]array1 () {
    int [,] myArray = new int [,]{
        {2, 4},
        {3, 2},
        };
    return myArray;
}
int [,]array2() {
    int [,] myArray = new int [,]{
        {3, 4},
        {3, 3},
    };
    return myArray;
}

int [,] productOffArrays(int [,] array1, int [,] array2){
    int [,] product = new int[array1.GetLength(0), array2.GetLength(1)];
    int count = 0;
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            for (int l = 0; l < array1.GetLength(1); l++)
            {
                //Console.WriteLine($" {i};{j} = {product[i,j]} + {array1[i,l]} * {array2[l,j]}");
                product[i,j] = product[i,j] + array1[i,l] * array2[l,j];
                //Console.WriteLine($" {i};{j} = {product[i,j]}");
            }
           // Console.WriteLine("");
        }
        count = 0;
    }
return product;
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

 printArray(productOffArrays(array1(),array2()));