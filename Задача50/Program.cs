// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


Console.Clear();

Console.Write("Введите позицию элемента: ");

int position = int.Parse(Console.ReadLine());

int[,] array = FillArray(60, 60, 0, 9);

PrintArray(array);

SearchPositionElement(array, position);

void SearchPositionElement(int[,] workerArray, int line)
{

    for (int i = 10; position / i > 0; i = i * 10)

    {
        int remainsNumber = (position % i);

        int wholeNumber = (position / i);

        if (remainsNumber <= workerArray.GetLength(0) && wholeNumber <= workerArray.GetLength(1))
            Console.WriteLine($"Значение элемента в позиции ({wholeNumber},{remainsNumber}) равняется {workerArray[wholeNumber, remainsNumber]}");

        else Console.WriteLine($"Позиция ({wholeNumber},{remainsNumber}) в массиве  отсутствует");
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




