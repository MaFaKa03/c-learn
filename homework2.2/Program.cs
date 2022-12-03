//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

void num(int N)
{
    int i=1;
    double pere;
    while (i<=N)
    {
        pere = Math.Pow(i, 3);
        Console.Write($"{pere}, ");
        i++;

    }
}
Console.WriteLine("Введите число");
int cheslo=int.Parse(Console.ReadLine());
num(cheslo);