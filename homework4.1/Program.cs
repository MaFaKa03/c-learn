//Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int Num(int A)

{
    int count = 0;
    while (A > 0)
    {
        count = count + (A % 10);
        A = A / 10;
    }
    return count;
}

Console.WriteLine(Num(int.Parse(Console.ReadLine())));