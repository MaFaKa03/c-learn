//Задача 2. Напишите программу, которая на вход принимает позиции
//элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

int[,] Massiv(int line, int column)
{
    int[,] array = new int[line, column];
    for(int i = 0; i < line; i++)
        for(int j = 0; j < column; j++)
            array[i,j] = new Random().Next (0, 10);
    return array;    
}

void Print(int[,] array)
{
    int line = array.GetLength(0);
    int column = array.GetLength(1);
    for(int i = 0; i < line; i++)
        {for(int j = 0; j < column; j++)
            Console.Write($"{array[i,j], 2}");
            Console.WriteLine();
        }
}

string Find(int[,] array, int f, int s)
{
    int line = array.GetLength(0);
    int column = array.GetLength(1);
    for(int i = 0; i < line; i++)
        for(int j = 0; j < column; j++)
            if (f == i+1 && s == j+1)
                return $"{array[f - 1,s - 1]}"; 
            return "Такого числа в массиве нет";         
}

int[,] array_1 = Massiv(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(array_1);

Console.WriteLine("Введите первую позицию");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("Введите вторую позицию");
int second = int.Parse(Console.ReadLine());

Console.WriteLine(Find(array_1, first, second));