using System;

Console.Clear();
Console.WriteLine("Введите число: ");
int number1 = int.Parse(Console.ReadLine());
int number2 = 2;

while(number2 <= number1)
{
    Console.WriteLine(number2);
    number2 +=2;
}