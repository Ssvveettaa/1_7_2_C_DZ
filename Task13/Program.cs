// Задача 13:
// Напишите программу, которая
// выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
// 645   –> 5
// 78    –> третьей цифры нет
// 32679 –> 6

int ThirdDigit(int num)
{
    while (num > 999) num /= 10;
    return num % 10;
}

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());

int module = number < 0 ? number * -1 : number;
if (module > 99)
{
    int result = ThirdDigit(module);
    Console.WriteLine($"Третья цифра числа {number}: {result}");
}
else Console.WriteLine("Третьей цифры нет.");
