// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

Console.WriteLine("Введите значение углового коэффициента К1 первой прямой: ");

double k1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение параметра b1  первой прямой: ");

double b1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение углового коэффициента К2 второй прямой: ");

double k2 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение параметра b2  второй прямой: ");

double b2 = double.Parse(Console.ReadLine());

double coordinataIntersectionX = ((b1 - b2) / (k2 - k1));

double coordinataIntersectionY = ((k2 * b1) - (k1 * b2)) / (k2 - k1);

if(k1 != k2) Console.WriteLine($"Координаты точки пересечения прямых: ({coordinataIntersectionX}; {coordinataIntersectionY})");

else Console.WriteLine("Прямые параллельны! Не имеют точку пересечения");



