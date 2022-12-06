// Напишите программу, которая
// 1.принимает на вход цифру, обозначающую день недели, 
// 2.проверяет, является ли этот день выходным.

Console.WriteLine("День недели: ");
int number = Convert.ToInt32(Console.ReadLine());

bool DayOfWeeek(int num)
{
    return num ==6 || num == 7;
}

if (number >= 1 && number < 8)
{
    bool result = DayOfWeeek(number);
    Console.WriteLine(result ? "Да" : "Нет");
}
else Console.WriteLine($"Этот ({number}) день в неделе не выходной");