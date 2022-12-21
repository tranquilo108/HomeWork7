/*Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/



void PrintArray(double[,] ints)
{
    for (int i = 0; i < ints.GetLength(0); i++)
    {
        for (int j = 0; j < ints.GetLength(1); j++)
        {
            Console.Write($"{ints[i, j]} ");
        }
        Console.WriteLine();
    }
}

static double[,] FillArray()
{
    Console.WriteLine("Введите количество строк массива: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    double[,] ints = new double[m, n];
    for (int i = 0; i < ints.GetLength(0); i++)
    {
        for (int j = 0; j < ints.GetLength(1); j++)
        {
            ints[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) /10;
        }
    }
    return ints;
}

double[,] ints = FillArray();
PrintArray(ints);
