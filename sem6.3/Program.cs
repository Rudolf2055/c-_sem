﻿// Задача 42: Напишите программу, 
// которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Random rnd = new Random();
int number = rnd.Next(0, 100);
Console.Write($"{number} ---> ");


string ConvertToBin (int num)
{
    string result = string.Empty;
    while (num > 0)
    {
        result = num % 2 + result;
        num /= 2;
    }
    return result;
}

string res = ConvertToBin(number);
Console.WriteLine (res);