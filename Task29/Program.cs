﻿
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int[] array = new int[8];
FillArray(array);
PrintArray(array);

// Console.WriteLine($"{array}");


void FillArray(int[] arr)
{ Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 100);
    }
 
}
void PrintArray(int[] arr)
{Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"{arr[i]}, ");
}
//Console.Write($"{arr[arr.Lenght-1]}");
Console.Write("]");
}
