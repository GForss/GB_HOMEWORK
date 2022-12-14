using System;
using static System.Console;
Clear();

int[] array = Hreh(ReadLine());

int[] Hreh(string massiv)
{
    string[] arr1 = massiv.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[arr1.Length];

    for (int i = 0; i < arr1.Length; i++)
    {
        result[i] = int.Parse(arr1[i]);
    }
    return result;
}

WriteLine(String.Join(",", array));

int number = Summ(array);

int Summ(int[] arr)
{
    int itog = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            itog++;
        }
    }
    return itog;
}

WriteLine(number);