// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.WriteLine ("Введите число ");
int num=int.Parse (Console.Readline()!);
int index = 1;
int K = 1;
Console.Write($"{num}->");
while (index <= num)
{
    K = index * index * index;
    Console.Write($"{K}");
    if (index !=num)
    {   
    Console.Write($"N");
    }
    index++;
}