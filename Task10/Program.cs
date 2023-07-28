// Задача 10:
// Напишите программу, которая
// принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 –> 5
// 782 –> 8
// 918 –> 1

int SecondDigit(int num)
{
    if (num < 0) num *= -1;
    return num >= 100 && num <= 999 ? num / 10 % 10 : -1;
}

Console.WriteLine("Введите целое трёхзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

int result = SecondDigit(number);
Console.WriteLine(result >= 0 && result <= 9 ? $"Вторая цифра числа {number}: {result}" : "Число не трёхзначное.");
