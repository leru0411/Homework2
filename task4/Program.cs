// Задача 4: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int a = Prompt("Введите номер дня недели: ");
string[] week = {"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};
if (a >= 1 && a <= 7)
{
    if (a >= 6 && a <= 7)
    {
        Console.Write($"{a} - это {week[a-1]} - выходной день недели");
    }
    else
    {
        Console.Write($"{a} - это {week[a-1]} - будний день недели");
    }
}
else{
    Console.Write("Такого дня недели нет");
}