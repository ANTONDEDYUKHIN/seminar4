/*Задача 27: Напишите программу, которая принимает на вход число
 и выдаёт сумму цифр в числе. 452 -> 11, 82 -> 10, 9012 -> 12 */
Console.Clear();
Console.WriteLine("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int perem = num;
int summ = 0;
while (num > 0)
    {
    summ = summ + num % 10;
    num = num /10 ;
    }
    Console.WriteLine($"Сумма цифр числа {perem}: {summ}");