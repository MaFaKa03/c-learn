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
}
    if (a<b) 
   {
        max = b;
        min = a;
   }

    else

    Console.Write("числа равны");


Console.Write(max, min);