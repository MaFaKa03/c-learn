//Задача 1: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

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
    Console.WriteLine();    
}

int[,] Sort(int[,] array)
{
    int line = array.GetLength(0);
    int column = array.GetLength(1);
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = 0; k < column - j - 1; k++ )
                if (array[i,k] < array[i,k+1])
                    (array[i,k], array[i,k+1]) = (array[i,k+1], array[i,k]);
                        
                //Console.WriteLine();   
                //Console.Write($"{array[i,j] , 2}");           
        }
        
                                   
    }
    return array;  
}

void PrintSort(int[,] array)
{
    int line = array.GetLength(0);
    int column = array.GetLength(1);
    for(int i = 0; i < line; i++)
        {
            for(int j = 0; j < column; j++)
                Console.Write($"{array[i,j], 2}");
                Console.WriteLine();
        }
}

int[,] array_1 = Massiv(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(array_1);
int [,] array_2 = Sort(array_1);
PrintSort(array_2);