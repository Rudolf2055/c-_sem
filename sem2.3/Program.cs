﻿// 456 -> 46
int MinusMidle(int num)
{
    int firstDigit = num / 100;
    int secondDigit = num % 10;
    int result = firstDigit * 10 + secondDigit;
    return result;
}

int number = new Random().Next(100, 1000);

Console.WriteLine(number);

int res = MinusMidle(number);

Console.WriteLine(res);