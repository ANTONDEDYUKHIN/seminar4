/*Написать программу, которая принимает на вход
число и выдает кол-во цифр в числе 456 - 3, 78 - 2б, 89126 - 5*/
Console.Clear();
Console.WriteLine("Enter a positive number: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 0;
if (number < 0)
{
    number = - number;
}
int input = number;
while (number > 0)
{
    number /=10;
    i++;
}
Console.WriteLine($"The entered number {input} consists  of {i} digits");