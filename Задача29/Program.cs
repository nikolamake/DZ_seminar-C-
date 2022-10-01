// Задача 29: Напишите программу, которая задаёт массив из N элементов и 
// выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


Console.Clear();

Console.WriteLine("Введите количество элементов массива: ");

int N = int.Parse(Console.ReadLine());


int[] RandomArray(int quantity)
{
int[] random = new int[quantity];

    for (int i = 0; i < quantity; i++)
        {
            random[i] = new Random().Next(0, quantity + 1);
        }
        return random;
}
Console.WriteLine($"Массив из {N} случайных чисел от 1 до {N}:");
Console.Write("[ " + String.Join(", " ,RandomArray(N))+" ]");
