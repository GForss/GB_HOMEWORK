using System;

Console.Clear();
Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine());

if(number1 > number2 & number1 > number3)
{
    Console.WriteLine($"Самое больше: {number1}");
}
else if(number2 > number1 & number2 > number3)
{
    Console.WriteLine($"Самое больше: {number2}");
}
else if(number3 > number1 & number3 > number2)
{
    Console.WriteLine($"Самое больше: {number3}");
}