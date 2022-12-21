/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7->такого числа в массиве нет*/


internal class Program
{
    private static void Main(string[] args)
    {
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
                    ints[i, j] = new Random().Next(-100, 100);
                }
            }
            return ints;
        }
        void PrintArray(int[,] ints)
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
        

        static void CheckElement(int[,] ints)
        {
            Console.WriteLine("Введите номер строки: ");
            int a = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine("Введите номер столбца: ");
            int b = Convert.ToInt32(Console.ReadLine()) - 1;
            if (a >= 0 && a <= ints.GetLength(0) - 1 && b >= 0 && b <= ints.GetLength(1) - 1)
            {
                Console.WriteLine(Convert.ToString($"Число с введенными координатами = {ints[a, b]}"));
            }
            else
            {
                Console.WriteLine("Такого элемента нет");
            }
        }
        int[,] ints = FillArray();
        PrintArray(ints); // Выводим массив на экран чтобы была возможность проверить нашу программу
        CheckElement(ints);
    }
}