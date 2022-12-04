//Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int Dote(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}

double Distance(int ax, int ay, int az, int bx, int by, int bz)

{
    double result;
    result = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
    return result;
}


int ax = Dote("ВВедите Ax");
int ay = Dote("ВВедите Ay");
int az = Dote("ВВедите Az");
int bx = Dote("ВВедите Bx");
int by = Dote("ВВедите By");
int bz = Dote("ВВедите Bz");

Console.WriteLine(Math.Round(Distance(ax, ay, az, bx, by, bz), 2));