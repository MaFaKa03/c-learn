//Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("введите число");
int Num = int.Parse(Console.ReadLine());

if (Num>999)
   {
    Console.WriteLine("не трёхзначное число");
   }
else if (Num < 100)
    {
    Console.WriteLine("не трёхзначное число");
    }
else
{
  Num = Num % 100;
  Num = Num / 10; 
  Console.WriteLine(Num); 
}