// Задача 49. Задайте двумерный массив
// Найти элементы, у которых оба индекса четные
// Заменить их на их квадраты 


int [,] CreatMatrixRndInt(int rows, int columns, int min, int max) 
{                                                                 
    int [,] matrix = new int[rows, columns]; 
    Random rnd = new Random(); 

    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    } 
    return matrix;
}


void PrintMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) -1) Console.Write($"{matrix[i, j], 4}, "); 
            else Console.Write($"{matrix[i, j], 4}");       
        }
        Console.WriteLine("]");
    }
}
 

void NewMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2)
        matrix[i, j] = matrix[i, j] * matrix[i, j];
    }
}


int[,] array2D = CreatMatrixRndInt(10, 4, 1, 9);
PrintMatrix(array2D);
Console.WriteLine(" ");
NewMatrix(array2D);
PrintMatrix(array2D);
