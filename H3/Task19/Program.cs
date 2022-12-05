using System;
using static System.Console;
Clear();

WriteLine("Введите число: ");
string numbr = ReadLine();
int len = numbr.Length;

if (numbr[0] == numbr[4] && numbr[1] == numbr[3]) {
    WriteLine("Палиндорм");
} else {
    WriteLine("Нет");
}