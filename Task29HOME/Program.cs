/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]*/
Console.Clear();
Console.Write("Enter the SIZE of the array of number: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the LARGEST number of the array: ");
int maxDig = Convert.ToInt32(Console.ReadLine());
void MasRandom(int[] array)
{
    Random rmd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rmd.Next(0, maxDig);
    }
}

void ShowArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i <= array.Length-1; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}

Console.WriteLine("Вывод массива:");
int[] mas = new int [size];// size = 8
MasRandom(mas);
ShowArray(mas);