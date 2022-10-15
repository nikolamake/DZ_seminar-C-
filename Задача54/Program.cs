// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.Clear();

Console.WriteLine("Введите количество строк двумерного массива");
int rowCount = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива");
int columnCount = int.Parse(Console.ReadLine());

Console.WriteLine("Введите минимальное значение в массиве: ");

int minMeaning = int.Parse(Console.ReadLine());

Console.WriteLine("Введите максимальное значение в массиве: ");

int maxMeaning = int.Parse(Console.ReadLine());

int[,] array = FillArray(rowCount, columnCount, minMeaning, maxMeaning);

Console.WriteLine("Исходный массив");
PrintArray(array);

Console.WriteLine("Массив  по убыванию элементов в строке");
PrintArray(SortingReduction(array));



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

int[,] SortingReduction(int[,] sourceArray)

{
    for (int i = 0; i < sourceArray.GetLength(0); i++)
    {
        for (int j = 0; j < sourceArray.GetLength(1); j++)
        {
            for (int k = 0; k < sourceArray.GetLength(1) - 1; k++)
                if (sourceArray[i, k] < sourceArray[i, k + 1])
                {
                    int temp = sourceArray[i, k + 1];
                    sourceArray[i, k + 1] = sourceArray[i, k];
                    sourceArray[i, k] = temp;
                }
        }

    }
    return sourceArray;
}











