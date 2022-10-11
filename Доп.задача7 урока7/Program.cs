// Дополнительная задача (задача со звёздочкой): Задайте двумерный массив из целых чисел. 
// Определите, есть столбец в массиве, сумма которого, больше суммы элементов расположенных 
// в четырех "углах" двумерного массива.

// Например, задан массив:
// 4 4 7 5
// 4 3 5 3



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

SumColumn(array);

void SumColumn(int[,] workerArray)
{   
    int sumСorners = workerArray[0,0] + workerArray[0,workerArray.GetLength(1) - 1] + workerArray[workerArray.GetLength(0) - 1,0] + workerArray[workerArray.GetLength(0) - 1,workerArray.GetLength(1) - 1];
    int sumColumn = 0;
    for (int i = 0; i < workerArray.GetLength(1); i++)
    
    {
        for (int j = 0; j < workerArray.GetLength(0); j++)
        {
           sumColumn = sumColumn + workerArray[j, i];
            int count = i;
        }
        if(sumColumn > sumСorners ) Console.WriteLine($"Сумма чисел {sumColumn} в столбце {i} больше суммы  чисел {sumСorners} в углах массива  ");
        else if(sumColumn < sumСorners ) Console.WriteLine($"Сумма чисел {sumColumn} в столбце {i} меньше суммы {sumСorners} чисел в углах массива ");
        else Console.WriteLine($"Сумма чисел {sumColumn} в столбце {i} равна сумме {sumСorners} чисел в углах массива ");
        sumColumn = 0;
       
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