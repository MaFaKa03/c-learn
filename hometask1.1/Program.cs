//Напишите программу, которая выводит случайное
//трёхзначное число и удаляет вторую цифру этого числа.
//645 -> 65
//782 -> 72
//918 -> 98

int a=0;
int num1(int num)
{
    Console.WriteLine(num);
    a = a + num / 100;
    a = a*10;
    return num % 10 + a;

    

}    
Console.WriteLine(num1(new Random(). Next(100, 1000)));