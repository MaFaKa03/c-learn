//Задача 2: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка

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

int[] LineSum(int[,] array)
{
    int line = array.GetLength(0);
    int column = array.GetLength(1);
    int num;
    int [] arr = new int[line];
    for (int i = 0; i < line; i++)
    {
        num = 0;
        for (int j = 0; j < column; j++)
        { 
            //num+=array[i,j];
            //Console.Write($"{num, 4}");
            arr[i] += array[i, j];       
        }
               //for(int k = 0; k < line; k++)
                    //arr[k]= num;
        
    }
    return arr;    
}

void MinSum(int[] arr)
{
    int size = arr.Length;
    int min = arr[0];
    int l=0;
    //int position = 0;

    for(int k = 0; k < size; k++)
    {   
        if (arr[k] < min) min = arr[k];
        if (arr[k] < arr[l]) l = k;
            
    }          
            Console.Write($"Минимальная сумма чисел находится в строке {l+1} и ровна {min}");   
    

}


int[,] array_1 = Massiv(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(array_1);
int [] array_2 = LineSum(array_1);
MinSum(array_2);