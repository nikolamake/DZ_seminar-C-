// Задача 4. Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.

Console.Clear();

Console.Write("Введите первое число: ");

double number1 = double.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");

double number2 = double.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");

double number3 = double.Parse(Console.ReadLine());

double max = number1;

double min = number2;

if(number1 > number2) 
    max = number1;

else
    max = number2;
    min = number1;

if(number3 > max) 
    max = number3;

else
    if(number3 < min)
        min = number3;    

if(max != min) 
    {
    Console.WriteLine($"Максимальное число равно {max}");

    Console.WriteLine($"Минимальное число равно {min}");
    }
   
else
  
    Console.WriteLine($"Максимальное число равно минимальному равно: {max}");