﻿//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
 
Console.Clear();

Console.WriteLine("Введите пятизначное число: ");

int number = int.Parse(Console.ReadLine());

if (number/10000 < 1 || number/10000 >= 10)
    {
        Console.WriteLine($"Число {number} не является пятизначным!");
    }
else if(number / 10000 == number % 10 && ((number / 1000) % 10 == (number / 10) % 10))
        
        {
        Console.WriteLine($"Число {number} является палиндромом");   
        }
    else
        {
        Console.WriteLine($"Число {number} не является палиндромом!"); 
        }







