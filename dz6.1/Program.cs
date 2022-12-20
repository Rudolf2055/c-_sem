// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


Console.Write("Сколько чисел будет введено?: ");
int quantity = Convert.ToInt32(Console.ReadLine());

int [] NewArray(int size)
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите числа: ");
        int digits = Convert.ToInt32(Console.ReadLine());
        array[i] = digits;
    }
    return array;
}


void PrintArray(int [] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]} ");    
    }
}


void Result (int [] array)
{
    Console.WriteLine();
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count += 1;
    }
    Console.WriteLine($"Чисел больше нуля = {count}");
}


int [] arr = NewArray(quantity);
PrintArray(arr);
Result(arr);