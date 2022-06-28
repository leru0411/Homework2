// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int n = Prompt("Введите любое число: ");
Console.WriteLine(n);
if (n > 99)
{
    while (n > 1000)
    {
        n = n / 10;
    }
    Console.Write(n % 10);
}
else
{
    Console.Write($"В числе {n} нет третьей цифры");
}