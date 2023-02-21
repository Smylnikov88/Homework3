//Задача 21
//Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
//AB = √(xb - xa)2 + (yb - ya)2+(zb-za)2

Console.Write( "Введите координаты первой точки X1: ");
int X1 = int.Parse(Console.ReadLine()!);

Console.Write( "Введите координат первой точки Y1: ");
int Y1 = int.Parse(Console.ReadLine()!);

Console.Write( "Введите координат первой точки Z1: ");
int Z1 = int.Parse(Console.ReadLine()!);

Console.Write( "Введите координаты второй точки X2: ");
int X2 = int.Parse(Console.ReadLine()!);

Console.Write( "Введите координат первой точки Y2: ");
int Y2 = int.Parse(Console.ReadLine()!);

Console.Write( "Введите координат первой точки Z2: ");
int Z2 = int.Parse(Console.ReadLine()!);

int A = (X2-X1)*(X2-X1);
int B = (Y2-Y1)*(Y2-Y1);
int Z = (Z2-Z1)*(Z2-Z1);
double ABZ = Math.Sqrt(A+B+Z);
Console.Write(Math.Round (ABZ, 3));
