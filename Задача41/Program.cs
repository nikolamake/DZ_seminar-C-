// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

Console.Write("Введите числа через запятую: ");

string numbers = Console.ReadLine();

int PositiveNumbersArray(string line)
{
    int total = 1;

    int minus = 0;

    for (int i = 0; i < line.Length; i++)
    {
        if (line[i] == ',') total = total + 1;
        else if (line[i] == '-') minus = minus + 1;
    }

    int positivNumbers = total - minus;

    return positivNumbers;

}

Console.WriteLine($"Количество положительных чисел : {PositiveNumbersArray(numbers)}");



