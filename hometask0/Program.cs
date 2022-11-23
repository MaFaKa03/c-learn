Console.WriteLine("введите первое число:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("введите второе число:");
int b = int.Parse(Console.ReadLine());

int max = a;

if(a>b) max=a;
else max = b;

Console.Write(max);
