// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
console.clean ();
Console.Write ("введите координаты точки Xa: ");
int Xa=int.Parse(Console.ReadLine()!);
Console.Write ("введите координаты точки Ya: ");
int Ya=int.Parse(Console.ReadLine()!);
Console.Write ("введите координаты точки Za: ");
int Za=int.Parse(Console.ReadLine()!);
Console.Write ("введите координаты точки Xb: ");
int Xb=int.Parse(Console.ReadLine()!);
Console.Write ("введите координаты точки Yb: ");
int Yb=int.Parse(Console.ReadLine()!);
Console.Write ("введите координаты точки Zb: ");
int Zb=int.Parse(Console.ReadLine()!);
int координаты (координата, точка);
{
    Console.Write ($"введите координаты точки: ");
    return Convert.ToInt16(Console.ReadLine());
}
double Decision(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Длина отрезка");