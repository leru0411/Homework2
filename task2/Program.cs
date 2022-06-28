// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
int rnd (int min, int max){
    Random rnd = new Random();
    return rnd.Next(min, max);
}

int a = rnd(100, 1000);
Console.WriteLine(a);

Console.Write(a / 100);
Console.Write(a % 10);
