/*написать программу, которая выводит массив из 8ми
элементов, заполненный нулями и единицами в случайном порядке*/
Console.Clear();
// Console.Write("Enter the SIZE of the array of number: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the LARGEST number of the array: ");
// int maxDig = Convert.ToInt32(Console.ReadLine());
void MasRandom(int[] array)
{
    Random rmd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rmd.Next(0, 3);
    }
}

void ShowArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i <= array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}

Console.WriteLine("Вывод массива:");
int[] mas = new int [8];
MasRandom(mas);
ShowArray(mas);