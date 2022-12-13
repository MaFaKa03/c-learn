//Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Dote(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 -k2); 
    double y = k1 * x + b1;
    double y2 = k2 * x + b2;
    
    if(x == y && x == y2 && y == y2)
    Console.WriteLine($"{x};{y}");
    else Console.WriteLine("Точки не пересекаются");
}

Dote(int.Parse(Console.ReadLine()),
    int.Parse(Console.ReadLine()),
    int.Parse(Console.ReadLine()),
    int.Parse(Console.ReadLine()));
                        
