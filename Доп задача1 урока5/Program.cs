// Дополнительная задача (задача со звёздочкой): Задайте одномерный массив, заполненный случайными числами. 
// Из входного массива сформируйте массив с чётными и массив с нечётными значениями элементов входного массива. 
// Найдите ср. арифметическое из полученных значений элементов массивов и выведите результат сравнения средних 
// арифметических.
// [1,2,3,4] -> средн. арифм. значений элементов массива с чётными числами > средн. арифм. значений 
// элементов с нечётными числами
// [2,3,5,7] -> средн. арифм. массива значений элементов с нечётными числами > средн. арифм. значений 
// элементов с чётными числами
// [1,2,5,4] -> средн. арифм. значений элементов массива с нечётными числами = средн. арифм. значений 
// элементов с чётными числами


Console.Clear();

Console.WriteLine("Введите минимальное значение в масиве: ");

int N = int.Parse(Console.ReadLine());

Console.WriteLine("Введите максимальное значение в масиве: ");

int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество элементов массива: ");

int T = int.Parse(Console.ReadLine());

int[] array = RandomArray(N, M, T); //общий массив

int[] Even = SearchEven(array); // массив из четных чисел

int[] Odd = SearchOdd(array); // массив из нечетных чисел

double arithMeanEven = Math.Round(ArithmeticMean(Even), 3); // ср арифмет четных чисел

double arithMeanOdd = Math.Round(ArithmeticMean(Odd), 3); // ср арифмет нечетных чисел

double ArithmeticMean(int[] array)
{

    double sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        sum = sum + array[i];
    }
    double arMean = sum / array.Length;

    return arMean;
}

int[] RandomArray(int lower, int upper, int quantity) // массив от lower до upper в количестве qantity
{
    int[] random = new int[quantity];

    for (int i = 0; i < quantity; i++)
    {
        random[i] = new Random().Next(lower, upper + 1);
    }

    return random;
}

int CountEven(int[] array)// кол-во четных эл-в в массиве
{

    int sumEven = 0;

    for (int i = 0; i < array.Length; i++)

    {
        if (array[i] % 2 == 0) sumEven = sumEven + 1;
    }

    return sumEven;
}

int CountOdd(int[] array)// кол-во нечетных эл-в в массиве
{

    int sumEven = 0;

    for (int i = 0; i < array.Length; i++)

    {
        if (array[i] % 2 != 0) sumEven = sumEven + 1;
    }

    return sumEven;
}

int[] SearchEven(int[] arr) // массив из четных эл-в
{
    int[] newArray = new int[CountEven(array)];

    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            newArray[j] = arr[i];
            j++;
        }
    }
    return newArray;
}

int[] SearchOdd(int[] arr) // массив из четных эл-в
{
    int[] newArray = new int[CountOdd(array)];

    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 != 0)
        {
            newArray[j] = arr[i];
            j++;
        }
    }
    return newArray;
}

Console.WriteLine($"Массив из {T} случайных целых чисел от {N} до {M}: [ " + String.Join(", ", array) + " ]");

Console.WriteLine($"Массив из четных чисел: [ " + String.Join(", ", Even) + " ]");

Console.WriteLine($"Количество четных чисел в массиве: {CountEven(array)}");

Console.WriteLine($"Среднее арифметическое значение четных чисел в массиве: {arithMeanEven}");

Console.WriteLine($"Массив из нечетных чисел: [ " + String.Join(", ", Odd) + " ]");

Console.WriteLine($"Количество нечетных чисел в массиве: {CountOdd(array)}");

Console.WriteLine($"Среднее арифметическое значение нечетных чисел в массиве: {arithMeanOdd}");


if (CountEven(array) == 0 || CountOdd(array) == 0)

    if (CountEven(array) == 0) Console.WriteLine($"Все элементы массива нечетные числа. Среднее арифметическое значение равно {arithMeanOdd}");

    else Console.WriteLine($"Все элементы массива четные числа. Среднее арифметическое значение равно {arithMeanEven}");
else
{
    if (arithMeanEven != arithMeanOdd)

        if (arithMeanEven > arithMeanOdd) Console.WriteLine($"Среднее арифметическое значение четных чисел больше среднего арифметического значения нечетных чисел.");

        else Console.WriteLine($"Среднее арифметическое значение нечетных чисел больше среднего арифметического значения четных чисел.");

    else
        Console.WriteLine($"Среднии арифметическии значения четных и нечетных чисел равны.");
}