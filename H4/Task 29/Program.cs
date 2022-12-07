using System;
using static System.Console;
Clear();

int[] array(int size) {

    int[] bro = new int[size];

    for (int i = 0; i < size; i++) {
        bro[i] = new Random().Next(0, 100);
    }
    return bro;
}   

WriteLine(String.Join(",", array(8)));