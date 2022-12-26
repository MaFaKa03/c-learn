//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

int[,] MassivFirst(int line, int column)
{
    int[,] arrayFirst = new int[line, column];
    for(int i = 0; i < line; i++)
        for(int j = 0; j < column; j++)
            arrayFirst[i,j] = new Random().Next (0, 10);
    return arrayFirst;    
}

void Print(int[,] arrayFirst)
{
    int line = arrayFirst.GetLength(0);
    int column = arrayFirst.GetLength(1);
    for(int i = 0; i < line; i++)
        {for(int j = 0; j < column; j++)
            Console.Write($"{arrayFirst[i,j], 2}");
            Console.WriteLine();
        }    
}

int[,] MassivSecond(int line, int column)
{
    int[,] arraySecond = new int[line, column];
    for(int i = 0; i < line; i++)
        for(int j = 0; j < column; j++)
            arraySecond[i,j] = new Random().Next (0, 10);
    return arraySecond;    
}

void Print1(int[,] arraySecond)

{
    int line = arraySecond.GetLength(0);
    int column = arraySecond.GetLength(1);
    for(int i = 0; i < line; i++)
        {for(int j = 0; j < column; j++)
            Console.Write($"{arraySecond[i,j], 2}");
            Console.WriteLine();
        }    
}

int[,] ProducrtMatrix(int [,] arryFist, int [,] arraySecond)
{
    int line1 = arryFist.GetLength(0);
    int column1 = arryFist.GetLength(1);
    int line2 = arraySecond.GetLength(0);
    int column2 = arraySecond.GetLength(1);
    int [,] prMatrix = new int[line1, column1];

    if (line1 != column2) return prMatrix;
    else if (line1 == column2) 
            prMatrix = new int[line1, line1];

    for (int i = 0; i < line1; i++)
    {
        for (int j = 0; j < line1; j++)
        {
            for (int k = 0; k < column1; k++)
            {
                prMatrix[i,j] += arryFist[i,k] * arraySecond[k,j];
            }
        }
        
    }
    return prMatrix;
}

void Print2(int[,] prMatrix)
{
    int line = prMatrix.GetLength(0);
    int column = prMatrix.GetLength(1);
    for(int i = 0; i < line; i++)
        {for(int j = 0; j < column; j++)
            Console.Write($"{prMatrix[i,j], 6}");
            Console.WriteLine();
        }    
}



int[,] array_1 = MassivFirst(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(array_1);
int[,] array_2 = MassivSecond(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print1(array_2);
int[,] array_3 = ProducrtMatrix(array_1, array_2);
Print2(array_3);
