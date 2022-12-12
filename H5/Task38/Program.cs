using System;
using static System.Console;
Clear();

int[] arr = NewMass(10);

int[] NewMass(int size) 
{
    int[] full = new int[size];

    for (int i = 0; i < size; i++)
    {
        full[i] = new Random().Next(0, 50);
    }
    return full;
}

WriteLine(String.Join(",", arr));

int subtraction = Perebor(arr);

int Perebor(int[] mass) 
{
    int min = int.MaxValue;
    int max = int.MinValue;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] < min) 
        {
            min = mass[i];
        } 
        else if (mass[i] > max)
        {
            max = mass[i];
        }
    }
    WriteLine(max);
    WriteLine(min);
    int result = max - min;
    return result;
}

WriteLine(subtraction);