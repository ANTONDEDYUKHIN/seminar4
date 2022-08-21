/*написать программу, которая выводит массив из 8ми
элементов, заполненный нулями и единицами в случайном порядке*/
Console.Clear();
Console.Write("Enter the SIZE of the array of number: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the LARGEST number of the array: ");
int maxDig = Convert.ToInt32(Console.ReadLine());
int[] NewArray()
{
    int[] array = new int[size];
    for (int i = 0; i <= (size-1); i++)
    {
        array[i] = new Random().Next(0, maxDig);
    }
    return array;
}
int [] array = NewArray();
void PrintArray()
{
    for (int i = 0; i <= (size-1); i++)
    {
        Console.Write($"{array[i]}, ");
    }
}
PrintArray();