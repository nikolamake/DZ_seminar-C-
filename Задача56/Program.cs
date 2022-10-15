// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 1 строка

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

PrintArray(array);

SumRow(array);

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

void SumRow(int[,] inputArray)
{
    int[] sumArray = new int[inputArray.GetLength(0)];

    for (int i = 0; i < inputArray.GetLength(0); i++)

    {
        int sum = 0;
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            sum = sum + inputArray[i, j];
        }
        sumArray[i] = sum;
        Console.WriteLine($"Суммма элементов {i} строки равняется {sumArray[i]}"); // для отображения суммы в строках
    }
    int min = sumArray[0];
    int minIndex = sumArray[0];
    for (int k = 1; k < sumArray.Length; k++)
    {
        if (sumArray[k] < min)
        {
            int temp = min;
            min = sumArray[k];
            sumArray[k] = temp;
            minIndex = k;
        }

    }
    Console.WriteLine($"Минимальная сумма элементов {min} в {minIndex} строке");
}
