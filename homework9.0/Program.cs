//Задача 1: Задайте значение N. Напишите программу,
//которая выведет все четные натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
//N = 5 -> "2, 4"
//N = 8 -> "2, 4, 6, 8"

void Num(int n)
 {
    if (n == 0) return;
        if (n % 2 == 0)
        {
            Num(n-2);    
            Console.Write($" {n} ");
        }   
        else 
        {   
            Num(n-3);    
            Console.Write($" {n-1} ");
        }     
 }
Console.WriteLine("Введите число");
Num(int.Parse(Console.ReadLine()));