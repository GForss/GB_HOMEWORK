using System;
using static System.Console;
Clear();

WriteLine("Введите через пробел массив: ");
int[] array = GetArray(ReadLine());

int[] GetArray(string Array) {
    string[] mass = Array.Split(' ',StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[mass.Length];

    for (int i = 0; i < mass.Length; i++) {
        result[i] = int.Parse(mass[i]);
    }
    return result;
}

WriteLine(String.Join(",", array));

int summ = GetSumm(array);

int GetSumm(int[] arr) {

    int itog = 0;

    for (int i = 0; i < arr.Length; i++) {
        if (arr[i] % 2 == 0) {
            itog = itog + arr[i];
        }
    }
    return itog;
}

WriteLine(summ);