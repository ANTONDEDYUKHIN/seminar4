/*Написать программу, которая принимает число А
и выдает сумму чисел от 1 до А.
7 - 28, 4 - 10, 8 - 36 */
Console.Clear();
Console.WriteLine("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = default; //0
for (int i = 1; i <= num; i++)// i++ инкремент, i-- декремент
{
    sum = sum + i;// sum +=i
}
Console.WriteLine($"Сумма чисел от 1 до {num} = {sum}");