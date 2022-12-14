// Задайте двумерный массив
// Напишите программу, которая 
// Заменяет строки на столбцы
// или напишите, что это невозможно сделать */



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


int [,] ReplaceRowsToColumns(int [,] matrix)
{
    int [,] newMatrix = new int [matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newMatrix[i, j] = matrix[j, i];
        }
    }
    return newMatrix;
}


int [,] matr = CreatMatrixRndInt(4, 4, 1, 10);
PrintMatrix(matr);
Console.WriteLine();
int [,] newMatr = ReplaceRowsToColumns(matr);
PrintMatrix(newMatr);