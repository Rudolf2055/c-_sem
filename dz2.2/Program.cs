// 13: Напишите программу, которая
// выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.Write("Enter a number; ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);

int ThirdDigit (int num)
{
    while (num > 1000) num = num / 10;
    return num = num % 10;
}

if (number > 99)
{
    int result = ThirdDigit(number);
    Console.WriteLine($"Третья цифра {number} is {result} ");
}
else Console.WriteLine("Третьей цифры нету");