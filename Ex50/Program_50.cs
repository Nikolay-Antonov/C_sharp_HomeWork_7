// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите количество строк двумерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] Fill2DArray()
{
    int[,] array = new int[rows, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
    return array;
}


void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void FindElementArray(int[,] array)
{
    Console.Write("Введите индекс искомого числа (через запятую): ");
    string[] find = Console.ReadLine().Split(',');
    int i = Convert.ToInt32(find[0]);
    int j = Convert.ToInt32(find[1]);
    if (i < 0 || i > array.GetLength(0) || j < 0 || j > array.GetLength(1))
        Console.WriteLine("Tакого числа нет");
    else
    {
        Console.WriteLine($"Число с индексом [{i},{j}] = {array[i, j]}");
    }
}


int[,] massiv = Fill2DArray();
Console.WriteLine($"Двумерный массив {rows} x {column} : ");
Print2DArray(massiv);
FindElementArray(massiv);