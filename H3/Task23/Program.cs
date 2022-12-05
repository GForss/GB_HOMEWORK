using System;
using static System.Console;
Clear();

WriteLine("Введите число: ");
double number = double.Parse(ReadLine());

for (int i = 1; i <= number; i++) {
    WriteLine(Math.Pow(i, 3));
}