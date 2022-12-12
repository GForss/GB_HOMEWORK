using System;
using static System.Console;
Clear();

int[] mas = Task(5);
int work = Perebor(mas);

int[] Task(int size) {

    int[] result = new int[size];

    for (int i = 0; i < size; i++) {
        result[i] = new Random().Next(100, 501);
    }
    return result;
}

int Perebor(int[] mass) {

    int itog = 0;

    for (int i = 0; i < mass.Length; i++) {
        if (mass[i] % 2 == 0) {
            itog++;
        }
    }
    return itog;
}

WriteLine(String.Join(",", mas));
WriteLine(work);