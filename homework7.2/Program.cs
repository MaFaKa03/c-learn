//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void MidSum(int[,] array)
{
    int line = array.GetLength(0);
    int column = array.GetLength(1);
    double res;
    for(int i = 0; i < column; i++)
        {
            res=0;
            for(int j = 0; j < line; j++) res+= array[j,i];
            Console.Write($"{Math.Round(res/line, 2)} ");
        }    


            
}

int[,] array_1 = Massiv(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(array_1);
MidSum(array_1);