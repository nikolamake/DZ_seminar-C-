// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.Clear();

Console.WriteLine("Введите минимальное значение в масиве: ");

int N = int.Parse(Console.ReadLine());

Console.WriteLine("Введите максимальное значение в масиве: ");

int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество элементов массива: ");

int T = int.Parse(Console.ReadLine());


int SumOdd(int[] arrayOdd) //сумма эл-в на нечетных позициях
{

int sumOdd = 0;

for (int i = 0; i < arrayOdd.Length; i++)
{
    if(i % 2 != 0) sumOdd = sumOdd + arrayOdd[i];
}
return sumOdd;

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

int[] array = RandomArray(N, M, T);

int sum = SumOdd(array);

Console.WriteLine($"Массив из {T} случайных чисел от {N} до {M}: [ " + String.Join(", ",array) + " ]");

Console.WriteLine($"Сумма чисел на  нечётных позициях в массиве: {sum}");