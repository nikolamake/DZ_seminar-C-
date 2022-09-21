//Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Clear();

Console.WriteLine("Введите трёхзначное число: ");

int number = int.Parse(Console.ReadLine());

if((number >= -999 && number <= -100) || (number >= 100 && number <= 999))
    if(number >= -999 && number <= -100)
        {
        int numberTwo = -((number / 10)) % 10;
 
        Console.WriteLine($"Вторая цифра числа {number} равна {numberTwo}."); 
        }
    else
        {int numberTwo = ((number / 10)) % 10;
 
        Console.WriteLine($"Вторая цифра числа {number} равна {numberTwo}.");

        }
else 

Console.WriteLine($"Введённое число {number} не является трёхзначным!");
