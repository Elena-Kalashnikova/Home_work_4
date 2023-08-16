// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите положительное число");
int number = Convert.ToInt32(Console.ReadLine());
int res_sum = SumNDigit(number);
Console.WriteLine($"Сумма цифр в {number} = {res_sum}");


int SumNDigit(int num)
{
if (num ==0) return 1;

    int sum = 0;
    while (num > 0)
    {

        sum += num % 10;
        num /= 10;

    }
    return sum;


}
