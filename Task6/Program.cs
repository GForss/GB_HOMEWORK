using System;

Console.Clear();
Console.WriteLine("Введите число: ");
int number1 = int.Parse(Console.ReadLine());
if((number1 % 2) == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число не четное");
}