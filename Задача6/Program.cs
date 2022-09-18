// Задача 6. Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

Console.Clear();

Console.WriteLine("Введите целое число:");

int number = int.Parse(Console.ReadLine());

if( (number % 2) !=0 ) // остаток от деления на "2"
    
     Console.WriteLine($"Число {number} является нечетным");
  
else
    Console.WriteLine($"Число {number} является четным");    