void Fibbonacci (int num)
{
    int a = 0, b = 1;

    for (int i = 0; i < num; i++)
    {
        Console.Write($"{a} ");
        (a, b) = (b, a+b);
    }
}

int num = int.Parse(Console.ReadLine());
Fibbonacci(num);