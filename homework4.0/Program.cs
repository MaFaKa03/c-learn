//Задача 1: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B. Без модуля Math, используем цикл for.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

void num(int A, int B)

{
    int result = A;
    for (int count = 1;count < B; count++)
    {
        result = result * A;
    }
    Console.WriteLine(result);
}   

Console.WriteLine("Введите число");
int A=int.Parse(Console.ReadLine());
Console.WriteLine("Введите число");
int B=int.Parse(Console.ReadLine());
num(A,B);
