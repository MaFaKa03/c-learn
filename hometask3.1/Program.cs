//Задача 4:
//Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите цифру");
int a = int.Parse(Console.ReadLine());

if(a>7)
{
    Console.WriteLine("Не является днем недели");
}
else if (a>5)
{
    Console.WriteLine("Выходной день");
}
else 
{
    Console.WriteLine("Не выходной день");
}