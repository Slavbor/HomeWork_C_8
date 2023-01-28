// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using System;
using static System.Console;
Clear();
WriteLine();
WriteLine("    # MaTrixs GeNeRaTiNg & Multiplication #");
WriteLine();

Write("Enter numbers of matrixs A rows: ");
int RowsMain = int.Parse(ReadLine()!);
Write("Enter numbers of matrixs A columns: ");
int ColumnsRowsMain = int.Parse(ReadLine()!);
Write("Enter numbers of matrixs B columns: ");
int ColumnsMain = int.Parse(ReadLine()!);

WriteLine();

int[,] array = GetMatrixArray(RowsMain, ColumnsRowsMain);
PrintMatrixArray(array);
WriteLine();

int[,] array2 = GetMatrixArray(ColumnsRowsMain, ColumnsMain);
PrintMatrixArray(array2);
WriteLine();

var result = MatrixMultiplication(array, array2);

PrintMatrixArray(result);





int[,] GetMatrixArray(int arrayRows, int arrayColumns)
{
    Random rnd = new Random();
    int[,] resultArray = new int[arrayRows, arrayColumns];
    for (int i = 0; i < arrayRows; i++)
    {
        for (int j = 0; j < arrayColumns; j++)
        {
            resultArray[i, j] = rnd.Next(0, 11);
        }
    }
    return resultArray;
}


void PrintMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j], 3} "); 
        }
        WriteLine();
    }
}

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{       
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
 
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            matrixC[i, j] = 0;
 
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
 
    return matrixC;
}