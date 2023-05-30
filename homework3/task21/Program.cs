// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Length(double xa, double ya, double za, double xb, double yb, double zb)
{
    double result = Math.Sqrt((xb-xa)*(xb-xa) + (yb-ya)*(yb-ya) + (zb-za)*(zb-za));
    return result;
}

System.Console.WriteLine("Введите первую координату точки А");
double xa = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите вторую координату А");
double ya = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите третью координату точки A");
double za = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите первую координату точки B");
double xb = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите вторую координату точки B");
double yb = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите третью координату точки B");
double zb = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine($"Расстояние между точками A и B равно: {Length(xa, ya, za, xb, yb, zb)}");




