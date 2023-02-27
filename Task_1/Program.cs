// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double [m,n];

void FillArray ( double[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int g = 0; g < arr.GetLength(1); g++)
    {
        arr[i,g] = new Random().NextDouble()+ new Random().Next(1,100);
    } 
}
}


void PrintArray(double[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int g = 0; g < matr.GetLength(1); g++)
        {
            Console.Write($"{Math.Round(matr[i, g],2)} ");
        }
        Console.WriteLine();
    }
}

FillArray(array);
PrintArray(array);