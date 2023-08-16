// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

using System.ComponentModel.Design;

Console.WriteLine("Введите положительное число A");
int number_a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите положительное число B");
int number_b = Convert.ToInt32(Console.ReadLine());
int degree = Exponentiation(number_a, number_b);
Console.WriteLine($"Результат возведения в степень натупального числа A в B = {degree}");


int Exponentiation(int num_a, int num_b)
{
    if (num_a == 0) return 0;
    if (num_b == 0) return 0;
    int stp = num_a;
    int count = 1;
    while (count < num_b)
    {
        stp *= num_a;
        count++;

    }
    return stp;
}