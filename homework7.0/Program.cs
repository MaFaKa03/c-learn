// Задача 1. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] Massiv(int line, int column)
{
    double[,] array = new double[line, column];
    Random n_new = new Random();

    for (int i = 0; i < line; i++)
        for (int j = 0; j < column; j++)
            array[i, j] = Math.Round(n_new.NextDouble() * (12 + 10) - 10, 2);
    return array;

}

void Print(double[,] array)
{
    double line = array.GetLength(0);
    double column = array.GetLength(1);
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($"{array[i,j],6} ");
        Console.WriteLine();
    }

}

double[,] arr = Massiv(int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()));
Print(arr);