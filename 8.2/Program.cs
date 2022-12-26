// 3. Составить частотный словарь элементов двумерного массива.
//    Частотный словарь содержит информацию о том, сколько раз 
//    встречается элемент входных данных. Значения элементов массива 0..9

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
void PrintMass(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.WriteLine($"{i} meets: {arr[i]}");
    Console.WriteLine();
}

int[] FrequencyDict(int[,] arr)
{
    int[] freq = new int[10];

    foreach (int item in arr)
        freq[item] += 1;

    return freq; 
}

int[,] array_1 = Massiv(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(array_1);
int[] mass = FrequencyDict(array_1);
PrintMass(mass);