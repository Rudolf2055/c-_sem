// // Задача 53:
// 1. Задайте двумерный массив.
// 2. Напишите программу, которая поменяет местами первую и последнюю строку массива.


int[,] array = CreateMatrixRndInt(3, 4, 1, 10);
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; //0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) //2
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, maxValue + 1); // 2 - 3
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength; j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("|");
    }
}

void ReplaceLines(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1)-1, i++)
    {
        int temp = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
        matrix[matrix.GetLength(0) - 1, i] = temp;
    }

}

PrintMatrix(array);
Console.WriteLine();
ReplaceLines(array);
Console.WriteLine();
PrintMatrix(array);