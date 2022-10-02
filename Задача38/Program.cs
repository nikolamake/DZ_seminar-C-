// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76


Console.Clear();

Console.WriteLine("Введите минимальное значение в масиве: ");

int N = int.Parse(Console.ReadLine());

Console.WriteLine("Введите максимальное значение в масиве: ");

int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество элементов массива: ");

int T = int.Parse(Console.ReadLine());


double[] RandomArray(int lower, int upper, int quantity) // массив от lower до upper в количестве qantity
{
double[] random = new double[quantity];

    for (int i = 0; i < quantity; i++)
    {
        random[i] = Math.Round((new Random().NextDouble() * (upper - lower) + lower), 3);
    }

return random;

}

double SubtractMaxMin(double[] array) // разница между макс и мин эл-м в массиве
{
double max = array[0];

double min = array[1];


if(max >= min)

    for (int i = 2; i < array.Length; i++)
    {
        if(array[i] > max) 
            max = array[i];
        else if(array[i] < min) 
            min = array[i];
    }
else 
    max = min;
    min = max;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
        else if(array[i] < min) min = array[i];
    }

return max - min;
}

double[] array = RandomArray(N, M, T);

double sub = Math.Round(SubtractMaxMin(array), 3);

Console.WriteLine($"Массив из {T} случайных вещественных чисел от {N} до {M}: [ " + String.Join("  ",array) + " ]");

Console.WriteLine($"Разница между максимальным и минималным числом в массиве: {sub}");