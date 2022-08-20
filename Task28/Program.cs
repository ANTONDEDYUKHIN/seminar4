/*Написать программу, которая принимает на вход
число Н и выдает произведение чисел от 1 до Н
4 - 24, 5 - 120 */
Console.Clear();
Console.Write("Enter a positive number: ");
int number = Convert.ToInt32(Console.ReadLine());
int composition = 1;
for (int i = 1; i <= number; i++)
{
    composition = composition * i;
}
Console.WriteLine($" The product of numbers from 1 to {number} is: {composition}");