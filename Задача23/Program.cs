// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

Console.WriteLine("Введите  число: ");

double number = double.Parse(Console.ReadLine());

Console.WriteLine($"Таблица кубов целых чисел от 1 до {number}: ");

if(number > 0)

    for (int i = 1; i <= number; i++)

    {
        double tableCub = Math.Pow(i, 3);
        Console.Write($"{tableCub} ");
    }
else
    for (int i = 1; i >= number; i--)

    {
        double tableCub = Math.Pow(i, 3);
        Console.Write($"{tableCub} ");
    }