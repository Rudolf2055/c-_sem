// 18. Напишите программу, которая по
// заданному номеру четверти, показывает диапозон
// возможных координат точек в этой четверти (x и y)

Console.WriteLine ("Введите номер четверти ");
int number = Convert.ToInt32(Console.ReadLine());

string Range(int num)
{
    if(num == 1) return "X > 0 и Y > 0";
    if(num == 2) return "X > 0 и Y > 0";
    if(num == 3) return "X > 0 и Y > 0";
    if(num == 4) return "X > 0 и Y > 0";
    return "Неверный номер четверти";
}
string result = Range(number);
Console.WriteLine(result);
