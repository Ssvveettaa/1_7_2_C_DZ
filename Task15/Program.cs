// Задача 15:
// Напишите программу, которая
// принимает на вход цифру, обозначающую день недели
// и проверяет является ли этот день выходным.
// 6 –> да
// 7 –> да
// 1 –> нет

bool Week(int number)
{
    return number > 0 && number <= 7 ? true : false;
}

bool Weekend(int day)
{
    return day > 5 ? true : false;
}

Console.WriteLine("Введите цифру, обозначающую день недели, чтобы узнать является ли этот день выходным:");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (Week(dayNumber))
{
    Console.WriteLine(Weekend(dayNumber) ? "Этот день является выходным." : "Этот день не является выходным.");
}
else Console.WriteLine("Это не день недели.");
