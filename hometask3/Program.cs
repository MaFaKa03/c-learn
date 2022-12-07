//Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
string a = Console.ReadLine();
int N = int.Parse(a);
int chet = 2;

while (chet<=N)
{
    Console.WriteLine($"{chet}");
    chet+=2;
}
if(chet>N)
{
    Console.WriteLine("Четных чисел нет");
}