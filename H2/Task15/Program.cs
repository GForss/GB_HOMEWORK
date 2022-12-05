using System;
using static System.Console;

Clear();

WriteLine("Введите число: ");
int number = int.Parse(ReadLine());


if (number == 6 || number == 7) {
    WriteLine("ВЫХОДНОЙ");
} else if (number > 0 && number < 6) {
    WriteLine("Опять работать =(");
} else {
    WriteLine("Некорректный ввод");
}
