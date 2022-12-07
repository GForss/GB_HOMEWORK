using System;
using static System.Console;
Clear();

int summ(int num) {

    int itog = 0;

    while (num > 0) {
        itog += num % 10;
        num = num / 10;
    }
    return itog;
}
 WriteLine(summ(int.Parse(ReadLine())));