// 4. Задайте двумерный массив из целых чисел. Напишите программу,
//    которая удалит строку и столбец, на пересечении которых 
//расположен наименьший элемент массива.

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

int[] MinEl(int[,] array)
{
    int line = array.GetLength(0);
    int column = array.GetLength(1);
    int min_num = array[0, 0];
    int[] indexes = new int[2];

    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
            if (min_num > array[i, j])
            {
                min_num = array[i, j];
                indexes[0] = i;
                indexes[1] = j;
            }
    }
    Console.WriteLine(array[indexes[0], indexes[1]]);
    return indexes;
}

void WithoutRowColumn(int[,] array, int[] m_indexes)
{
    int line = array.GetLength(0);
    int column = array.GetLength(1);
    
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
            if (m_indexes[0] == i || m_indexes[1] == j) continue;
            else Console.Write($"{array[i, j],3}");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] array_1 = Massiv(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(array_1);
int[] array_2 = MinEl(array_1);
WithoutRowColumn(array_2);
