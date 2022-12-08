//Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

void Massiv(int[] arr)
	{
	    int size = arr.Length;
	
	    for (int i = 0; i < size; i++)
	        Console.Write($"{arr[i]} ");
	    Console.WriteLine();
	}
int[] Print(int size)
	{
	    int[] arr = new int[size];
	
	    for (int i = 0; i < size; i++)
	        arr[i] = new Random().Next(100,1000);
	    return arr;
	}
void MassChet(int[]arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 ==0)
        {
            count++;
        }
        
    }
    Console.WriteLine(count);
}
int[] arr_1 = Print(int.Parse(Console.ReadLine()));
Massiv(arr_1);
MassChet(arr_1);