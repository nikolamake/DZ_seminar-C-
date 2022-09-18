// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.Clear();

Console.WriteLine("Введите целое число: ");

int number = int.Parse(Console.ReadLine());
 
Console.WriteLine($"Список четных чисел от 1 до {number}");

if(number > 0)
    {
    int ListEven = 2;

        while(ListEven <= number) 
        {
            Console.WriteLine(ListEven);
            ListEven = ListEven + 2;
        }
    }        
else
    {
    int ListEven = 0;

        while(ListEven >= number) 
        {
            Console.WriteLine(ListEven);
            ListEven = ListEven - 2;
        }
    }        