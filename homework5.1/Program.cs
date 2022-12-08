//Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 26
//[-4, -6, 4, 6] -> 0

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
	        arr[i] = new Random().Next(-100,100);
	    return arr;
	}



void MasSum(int[] arr)
{
    int count = 0;
    int i = 0;
    while (i<arr.Length)
    {
        if(i%2==0)
        {
            i++;
        }    
        else 
        {
            count=count + arr[i];
            i++;
        }    

    }
    Console.WriteLine(count);
}
int[] arr_1 = Print(int.Parse(Console.ReadLine()));
Massiv(arr_1);
MasSum(arr_1);   