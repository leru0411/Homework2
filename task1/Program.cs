// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает последнюю цифру этого числа: 456 -> 5
int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int n = Prompt("Введите трехзначное число: ");
if (n > 99 && n < 1000) Console.Write(n % 10);
else Console.Write("Вы ввели НЕ трехзначное число.");
