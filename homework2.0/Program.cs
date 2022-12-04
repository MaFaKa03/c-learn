//Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

void Num(int a)
{
    if (a>99999)
    {
        Console.WriteLine("непятизначное число");
    }
    else if (a/10000 == a%10)

        {
           if((a/1000)%10 == (a%100)/10)
           {
             Console.WriteLine("Палиндром");
             return;
           }
        
           else
           {
            Console.WriteLine("Непалиндром");
           }
        }

    else
    {
        Console.WriteLine("Непалиндром");
    }
    
}

Num (int.Parse(Console.ReadLine()));