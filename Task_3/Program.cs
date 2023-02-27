// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int g = 0; g < arr.GetLength(1); g++)
        {
            arr[i, g] = new Random().Next(1, 100);
        }
    }
}

void PrintArray(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int g = 0; g < matr.GetLength(1); g++)
        {
            Console.Write($"{matr[i, g]} ");
        }
        Console.WriteLine();
    }
}

void FindM(int[,] arif)
{
    for (int g = 0; g < arif.GetLength(1); g++)
    {
        double sum = 0;
        for (int i = 0; i < arif.GetLength(0); i++)
        {
            sum += arif[i, g];
        }
        double ar = sum / arif.GetLength(0);
        Console.Write($"{Math.Round(ar, 2)}; ");
    }
}

FillArray(array);
PrintArray(array);
FindM(array);