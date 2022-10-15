// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите количество строк первого двумерного массива");
int rowCount1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов первого двумерного массива");
int columnCount1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите минимальное значение в первом массиве: ");

int minMeaning1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите максимальное значение в первом массиве: ");

int maxMeaning1 = int.Parse(Console.ReadLine());


int[,] array1 = FillArray(rowCount1, columnCount1, minMeaning1, maxMeaning1);

Console.WriteLine();

Console.WriteLine("Матрица 1");
PrintArray(array1);

Console.WriteLine();

int[,] array2 = FillArray(columnCount1, rowCount1, minMeaning1, maxMeaning1);

Console.WriteLine("Матрица 2");
PrintArray(array2);

Console.WriteLine("Результат умножения матрицы 1 на матрицу 2");
PrintArray(ProductOfMatrices(array1, array2));

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

int[,] ProductOfMatrices(int[,] firstArray, int[,] secondArray)
{
   
    int[,] matrixMultiplication = new int[firstArray.GetLength(0), firstArray.GetLength(1)];
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {

        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < secondArray.GetLength(0); k++)

            {
                sum = matrixMultiplication[i, j];
                matrixMultiplication[i, j] = sum + firstArray[i, k] * secondArray[k, j];
            }

        }

    }
    return matrixMultiplication;

}