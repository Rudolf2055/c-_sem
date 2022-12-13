// Задача 26. напишите программу. которая принимает 
// на вход число и выдаёт колличество цифр в числе
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите любое целое число");
int number = Convert.ToInt32(Console.ReadLine());

int NumberDigit(int num) // int num = number
{
    int digit = 0;
    while (num != 0)
    {
        num = num / 10;
        digit++;
    }
    return digit == 0 ? 1 : digit;
}

int digitNumber = NumberDigit(number);
Console.WriteLine($"{number} -> {digitNumber}");

