// 25. Напишите цикл, который 
// принимает на вход два числа (A и B) 
// возводит число A в натуральную степень B.
// 3, 5 -> 243
// 2, 4 -> 16 */


Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
void NumberDegree(int number1, int number2)
{
    int result = 1;
    for (int i = 1; i <= number2; i++)
    {
        result = result * number1;
    }
    Console.Write($"Число {number1} в степени {number2} это {result} ");
}
if (num2 > 0 && num1 > 0)
{
    NumberDegree(num1, num2);
}
else Console.WriteLine("Неверное число");

