// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Clear();

Console.WriteLine("Введите количество строк двумерного массива");
int rowCount = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива");
int columnCount = int.Parse(Console.ReadLine());

Console.WriteLine("Введите минимальное значение в масиве: ");

int minMeaning = int.Parse(Console.ReadLine());

Console.WriteLine("Введите максимальное значение в масиве: ");

int maxMeaning = int.Parse(Console.ReadLine());

int[,] array = FillArray(rowCount, columnCount, minMeaning, maxMeaning);

PrintArray(array);

AverageColumn(array);

void AverageColumn(int[,] workerArray)
{
    double sum = 0;
    for (int i = 0; i < workerArray.GetLength(1); i++)

    {
        for (int j = 0; j < workerArray.GetLength(0); j++)
        {
            sum = Math.Round((sum + workerArray[j, i]), 2);
        }
        double averageSum = sum / workerArray.GetLength(0);
        Console.WriteLine($"Среднее арифметическое значение в столбце равняется {averageSum} ");
        sum = 0;
    }
}

int[,] FillArray(int rows, int columns, int min, int max)
{
    int[,] filledArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            filledArray[i, j] = new Random().Next(min, max + 1);
        }
    }
    return filledArray;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(" " + inputArray[i, j]);
        }
        Console.WriteLine();
    }
}