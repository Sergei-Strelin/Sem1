
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число, чтобы узнать четное оно или нет: ");
Console.Write("Введите число: ");

int num = int.Parse(Console.ReadLine());
int remain = num % 2;

if (remain == 0)
    Console.WriteLine("Число " + num + " четное!");
else
    Console.WriteLine("Число " + num + " нечетное!");
if (remain == 0)
{
    Console.WriteLine("Число " + num + " четное?");
    Console.WriteLine("ДА!");
}
else
{
    Console.WriteLine("Число " + num + " четное?");
    Console.WriteLine("НЕТ!");
}

