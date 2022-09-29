// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Enter x1: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter x2: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter x3: ");
int x3 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter y3: ");
int y3 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(x3-y3,2));
Console.WriteLine($"result = {result:f1}");