// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер строки искомого элемента");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца искомого элемента");
int y = Convert.ToInt32(Console.ReadLine());

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

void FindNumber(int[,] numb)
{
    if (x <= numb.GetLength(0) && y <= numb.GetLength(1)) Console.WriteLine(numb[x, y]);
    else Console.WriteLine("Такого элемента нет");

}

FillArray(array);
PrintArray(array);
FindNumber(array);