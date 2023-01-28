// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using System;
using static System.Console;
Clear();
WriteLine();
WriteLine("    # MaTrix GeNeRaTiNg & rows sorted #");
WriteLine();

Write("Enter numbers of matrix rows: ");
int RowsMain = int.Parse(ReadLine()!);
Write("Enter numbers of matrix columns: ");
int ColumnsMain = int.Parse(ReadLine()!);

WriteLine();

int[,] array = GetMatrixArray(RowsMain, ColumnsMain);
PrintMatrixArray(array);
WriteLine();


int[] row = new int[ColumnsMain];
for (int i = 0; i < RowsMain; i++)
{
    for (int j = 0; j < ColumnsMain; j++)
        row[j] = array[i, j];
    BubbleSort(row);
    Insert(true, i, row, array);
}
WriteLine("    Sorted array:");
WriteLine();
PrintMatrixArray(array);
WriteLine();




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
            Write($"{inArray[i, j], 4} "); 
        }
        WriteLine();
    }
}

void BubbleSort(int[] SortArray)
    {
        for (int i = 0; i < SortArray.Length; i++)
            for (int j = 0; j < SortArray.Length - i - 1; j++)
            {
                if (SortArray[j] < SortArray[j + 1])
                {
                    int temp = SortArray[j];
                    SortArray[j] = SortArray[j + 1];
                    SortArray[j + 1] = temp;
                }
            }
    }

 void Insert(bool isRow, int dim, int[] source, int[,] dest)
    {
        for (int k = 0; k < source.Length; k++)
        {
            if (isRow)
                dest[dim, k] = source[k];
            else
                dest[k, dim] = source[k];
        }
    }