// Дополнительная задача (задача со звёздочкой): Напишите программу, 
// которая задаёт массив из 10 элементов, которые необходимо заполнить 
// случайными значениями в диапазоне от -10 до 10 и найти максимальное значение 
// среди них.
// [-1, 2, 4, 6, -7, 9, -3, -4, -6 ,1] -> 9
// [-5, 1, -9, 6, -7, -2, -3, -4, -6 ,1] -> 6
// [-7, 2, 4, 6, -7, 7, -3, -4, -2 ,1] -> 7

Console.Clear();

Console.WriteLine("Введите минимальное значение в масиве: ");

int N = int.Parse(Console.ReadLine());

Console.WriteLine("Введите максимальное значение в масиве: ");

int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество элементов массива: ");

int T = int.Parse(Console.ReadLine());



int[] RandomArray(int lower, int upper, int quantity)
{
int[] random = new int[quantity];

    for (int i = 0; i < quantity; i++)
    {
        random[i] = new Random().Next(lower, upper + 1);
    }

return random;

}

int SearchMax(int[] array)
{
int MaxValue = array[0];

for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > MaxValue) 
       
        MaxValue = array[i];  
     
    }
return MaxValue;

} 

int[] array = RandomArray(N, M, T);

int maximum = SearchMax(array); 

Console.WriteLine($"Массив из {T} случайных элементов: [ " + String.Join(", ",array) + " ]");

Console.WriteLine($"Максимальное значение в массиве {maximum}");
