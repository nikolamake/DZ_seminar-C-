// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
 // A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.WriteLine("Введите координату X1 точки А");
double X1 = double.Parse(Console.ReadLine()); 

Console.WriteLine("Введите координату Y1 точки А");
double Y1 = double.Parse(Console.ReadLine()); 

Console.WriteLine("Введите координату Z1 точки А");
double Z1 = double.Parse(Console.ReadLine()); 

Console.WriteLine("Введите координату X2 точки B");
double X2 = double.Parse(Console.ReadLine()); 

Console.WriteLine("Введите координату Y2 точки B");
double Y2 = double.Parse(Console.ReadLine()); 

Console.WriteLine("Введите координату Z2 точки B");
double Z2 = double.Parse(Console.ReadLine()); 

double distance = Math.Sqrt(Math.Pow((X1 - X2), 2) + Math.Pow((Y1 - Y2), 2) + Math.Pow((Z1 - Z2), 2));

Console.WriteLine($"Расстояние между точкой А и точкой В равняется {Math.Round(distance, 2)}");