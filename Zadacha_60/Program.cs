// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
using System;
using static System.Console;

Clear();
WriteLine();
WriteLine("    # 3D MaTrix GeNeRaTiNg(Maximum 90 elements!) & elents index print#");
WriteLine();

Write("Enter numbers of matrix rows: ");
int RowsMain = int.Parse(ReadLine()!);
Write("Enter numbers of matrix columns: ");
int ColumnsMain = int.Parse(ReadLine()!);
Write("Enter numbers of matrix Z dimension: ");
int ColumnsMain2 = int.Parse(ReadLine()!);

if (RowsMain * ColumnsMain * ColumnsMain2 > 90)
{
    WriteLine();
    Write("Out of limit. No more 90 element. Program stopped");
    WriteLine();
    return;
}

WriteLine();
int[,,] array3d = new int[RowsMain, ColumnsMain, ColumnsMain2];

FillRandom(array3d, new Random());
PrintArray3d(array3d);

void FillRandom(int[,,] array3d, Random random)
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                int randNumber = random.Next(10, 100);

                while (Array3dContains(array3d, randNumber))
                {
                    randNumber = random.Next(10, 100);
                }

                array3d[i, j, k] = randNumber;
            }
        }
    }
}

bool Array3dContains(int[,,] array3d, int randNumber)
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                if (array3d[i, j, k] == randNumber)
                    return true;
            }
        }
    }

    return false;
}

void PrintArray3d(int[,,] array3d)
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                Write($"{array3d[i, j, k]}({i},{j},{k}) ");
            }
            WriteLine();
        }
    }
}
