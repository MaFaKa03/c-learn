//Задайте массив из 12 эллементов, заполненый случайными числами из промежутка [-9;9]
//Найдите сумму отрицательных и сумма положительных элементов

void Print(int[] arr)
	{
	    int size = arr.Length;
	
	    for (int i = 0; i < size; i++)
	        Console.Write($"{arr[i]} ");
	    Console.WriteLine();
	}
	
	int[] EightMass(int size)
	{
	    int[] arr = new int[size];
	
	    for (int i = 0; i < size; i++)
	        arr[i] = new Random().Next(1, 100);
	    return arr;
	}
	
	int[] arr_1 = EightMass(int.Parse(Console.ReadLine()));
	Print(arr_1);