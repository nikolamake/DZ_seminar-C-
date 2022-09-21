//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Clear();

Console.WriteLine("Введите число дня недели:");

int number = int.Parse(Console.ReadLine());

if(number < 1 || number > 7)
    
        Console.WriteLine($"Введённое число {number} не обозначает день недели!");

else
    
    if(number == 6 || number == 7)

       Console.WriteLine($"День недели является выходным.");

    else
        Console.WriteLine($"День недели является рабочим.");
