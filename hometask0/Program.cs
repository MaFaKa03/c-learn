Console.WriteLine("введите первое число:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("введите второе число:");
int b = int.Parse(Console.ReadLine());

int max = a;
int min = a;

if(a>b) 
{
    max = a;
    min = b;
    Console.WriteLine(max);
    Console.WriteLine(min);
}  
    if (a<b)
       {
          max = b;
          min = a;
       
        Console.WriteLine(max);
        Console.WriteLine(min);
       }
    else
        Console.WriteLine("числа равны");    