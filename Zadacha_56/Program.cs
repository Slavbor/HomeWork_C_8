// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
using System;
using static System.Console;
Clear();
WriteLine();
WriteLine("    # MaTrix GeNeRaTiNg & min summ in rows calc #");
WriteLine();

Write("Enter numbers of matrix rows: ");
int RowsMain = int.Parse(ReadLine()!);
Write("Enter numbers of matrix columns: ");
int ColumnsMain = int.Parse(ReadLine()!);

WriteLine();

int[,] array = GetMatrixArray(RowsMain, ColumnsMain);
PrintMatrixArray(array);
WriteLine();


int[] SummArray = new int[array.GetLength(0)];

int summ = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        summ += array[i, j];
    }
    SummArray[i] = summ;
    
    summ = 0;
}



int min = SummArray[0];
int index = 0;
 
for (int i = 1; i < SummArray.Length; i++)
 
    if (min > SummArray[i])
    {
        min = SummArray[i];
        index = i;
    }

WriteLine();
WriteLine($"Номер строки с наименьшей суммой элементов: {index+1}");




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

void PrintArray(int[] RowArray)
{
    Write("[");     
    for (int i = 0; i < RowArray.Length; i++)
    {
        Write($"{RowArray[i]}");
        Write(i < RowArray.Length - 1 ? ", " : "");
    }
    Write("]");
}
