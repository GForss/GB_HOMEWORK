using System;
using static System.Console;

Clear();

WriteLine("Введите число: ");
int number = int.Parse(ReadLine());
int end = number / 10;
int end1 = end % 10;
WriteLine(end1);