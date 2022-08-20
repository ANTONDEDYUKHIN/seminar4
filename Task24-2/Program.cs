/*Написать программу, которая принимает число А
и выдает сумму чисел от 1 до А.
7 - 28, 4 - 10, 8 - 36 */
Console.Clear();
Console.WriteLine("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int SumNumbers(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}
if (num > 0)
{
    int result = SumNumbers(num);
Console.WriteLine($"Сумма чисел от 1 до {num} = {result}");
}
else Console.WriteLine($"Некорректный ввод значения. Требуется положительное число");