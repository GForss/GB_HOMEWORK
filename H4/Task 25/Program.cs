using System;
using static System.Console;
Clear();

int numbers(int num1, int num2){

    int itog = num1;

    for (int i = 1; i < num2; i++) {
        itog *= num1; 
    }
    return itog;
}

WriteLine(numbers(int.Parse(ReadLine()), int.Parse(ReadLine())));
