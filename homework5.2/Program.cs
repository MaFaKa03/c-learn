//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

void Massiv(double[] arr)
	{
	    int size = arr.Length;
	
	    for (int i = 0; i < size; i++)
	        Console.Write($"{arr[i]} ");
	    Console.WriteLine();
	}
double[] Print(int size)
	{
	    double[] arr = new double[size];
		Random n_new = new Random(); 
	
	    for (int i = 0; i < size; i++)
	        arr[i] = Math.Round(n_new.NextDouble() * (12 + 10)-10,2);
	    return arr;
	}
void RazMass(double[] arr)
{
   double min = arr[0];
   double max = arr[0];
   double result = 0;
   for(int i = 1; i < arr.Length; i++)
   {
	if(arr[i] < min)
	{
		min = arr[i];
	}
	else if(arr[i] > max)
	
		max = arr[i];
	
   }
   result = result + (Math.Round(max - min, 2));
   Console.WriteLine(result);
}    

double[] arr_1 = Print(int.Parse(Console.ReadLine()));
Massiv(arr_1);
RazMass(arr_1);