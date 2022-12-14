using System;
using static System.Console;
Clear();

WriteLine("Введите b1: ");
double b1 = int.Parse(ReadLine());
WriteLine("Введите b2: ");
double b2 = int.Parse(ReadLine());
WriteLine("Введите k1: ");
double k1 = int.Parse(ReadLine());
WriteLine("Введите k2: ");
double k2 = int.Parse(ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

WriteLine($"X: {x}, Y: {y}");