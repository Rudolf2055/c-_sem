﻿// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23
// 14 -> нет
// 46 -> нет 
// 161 -> да

Console.WriteLine("Введите целове число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целове число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целове число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool MultiplicityTwoDigits (int num, int num1, int num2)
{
    return num % num1 == 0 && num % num2 == 0;
}

bool result = MultiplicityTwoDigits(number, number1, number2);

Console.Write($"{number} -> ");
Console.WriteLine(result ? "Да" : "Нет");
