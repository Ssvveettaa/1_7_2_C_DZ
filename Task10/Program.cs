// Задача 10:
// Напишите программу, которая
// принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 –> 5
// 782 –> 8
// 918 –> 1

void OutputSecondDigit(int num)
{
    int module = num < 0 ? num * -1 : num;
    Console.WriteLine(module >= 100 && module <= 999 ? $"Вторая цифра числа {num}: {module / 10 % 10}" : "Число не трёхзначное.");
}

Console.WriteLine("Введите целое трёхзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

OutputSecondDigit(number);
