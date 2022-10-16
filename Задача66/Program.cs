// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
//  в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.Clear();

Console.WriteLine("Введите начальное значение M : ");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите конечное значение N : ");
int N = int.Parse(Console.ReadLine());

NumberSum(M, N, 0);

void NumberSum(int initial, int final, int sum)
{

    if (initial > final)

    {
        Console.WriteLine($"Сумма натуральных элементов от M до N: {sum}");
        return;
    }
    sum = sum + (initial++);
    NumberSum(initial, final, sum);
}