// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Clear();
Console.WriteLaine ("Введите число ");
int num=int.Parse (ConsoleReadline()!);
int index = 1;
int K = 1;
Concole.Write($"{num}->");
while (index <= num)
{
    K = index * index * index;
    console.Write($"{K}");
    if (index !=num)
    {   
    Console.Write($"N");
    }
    index++;
}