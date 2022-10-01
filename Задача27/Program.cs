// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Clear();

Console.WriteLine("Введите число : ");

int M = int.Parse(Console.ReadLine());

int SumDigitsNumber(int number)
{
int sum = 0;

    for (int i = 1; i > 0; i = i * 10)
    {
        sum = sum + (number / i) % 10;
    }
    
    return sum;
}

Console.WriteLine($"Сумма цифр в числе {M} равняется {SumDigitsNumber(M)}");