﻿// Задача 50. Напишите программу,
// которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет



Console.Write("Введите значение строки: ");
int str = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение столбца: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию строки: ");
int rowPosition = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбца: ");
int colPosition = Convert.ToInt32(Console.ReadLine());



int [,] CreatMatrixRndInt(int rows, int columns, int min, int max)
{
    int [,] matrix = new int [rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix [i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}


void PrintMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 3}, ");
            else Console.WriteLine($"{matrix[i, j], 4}, ");
        }
    }
}


int FindPosition(int [,] matrix, int rowPos, int colPos)
{
    return matrix[rowPos - 1, colPos - 1];
}


int [,] matr = CreatMatrixRndInt(str, col, 1, 10);
PrintMatrix(matr);
int res = FindPosition(matr, rowPosition, colPosition);
Console.Write(matr[rowPosition, colPosition]);