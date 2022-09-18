// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

Console.Clear();

Console.Write("Введите первое число: ");

double number1 = double.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");

double number2 = double.Parse(Console.ReadLine());

if(number1 != number2)
    {
        if(number1 > number2)

            Console.WriteLine($"Наибольшее число: {number1} наименьшее число: {number2} ");
        else
            Console.WriteLine($"Наибольшее число: {number2} наименьшее число: {number1} ");    
    }
else
    Console.WriteLine($"Первое число равно второму равно: {number2} ");