// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


Console.Clear();

Console.WriteLine("Введите количество элементов массива: ");

int N = int.Parse(Console.ReadLine());

int CountEven (int[] array)// кол-во четных эл-в в массиве
{

int sumEven = 0;

for (int i = 0; i < array.Length; i++)

    {
        if (array[i] % 2 == 0 ) sumEven = sumEven + 1;
    }

return sumEven;
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

int[] array = RandomArray(100, 999, N);

int max = CountEven(array);

Console.WriteLine($"Массив из {N} случайных трёхзначных чисел: [ " + String.Join(", ",array) + " ]");

Console.WriteLine($"Количество четных чисел в массиве: {max}");