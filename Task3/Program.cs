/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/


static int[,] FillArray()
{
    Console.WriteLine("Введите количество строк массива: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] ints = new int[m, n];
    for (int i = 0; i < ints.GetLength(0); i++)
    {
        for (int j = 0; j < ints.GetLength(1); j++)
        {
            ints[i, j] = new Random().Next(0, 10);
        }
    }
    return ints;
}

static void AvgOfArray(int[,] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    
    for (int i = 0; i < array.GetLength(1); i++)
    {
        if(array.GetLength(1) - 1 != i)
        {
            double avg = 0;
            int count = 0;
            for (int j = 0; j < array.GetLength(0); j++)
            {
                avg += array[j, i];
                count++;
            }
            Console.Write($"{avg / count}; ");
        }
        else
        {
            double avg = 0;
            int count = 0;
            for (int j = 0; j < array.GetLength(0); j++)
            {
                avg += array[j, i];
                count++;
            }
            Console.Write($"{avg / count}. ");
        }
    }
}

void PrintArray(int[,] ints)
{
    Console.WriteLine("Заданный массив");
    Console.WriteLine();
    for (int i = 0; i < ints.GetLength(0); i++)
    {
        for (int j = 0; j < ints.GetLength(1); j++)
        {
            Console.Write($"{ints[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] ints = FillArray();
PrintArray(ints);
AvgOfArray(ints);