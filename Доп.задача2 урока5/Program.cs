// Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
// Дополнительная задача 2 (задача со звёздочкой): Задайте одномерный массив из N элементов, заполненный случайными числами. 
// Необходимо определить, в какой последовательности заданы элементы массива: по возрастанию, по убыванию, хаотично, или все элементы одинаковы.
// [1,2,3,4] -> по возрастанию
// [4,3,2,1] -> по убыванию
// [4,2,3,1] -> хаотично
// [1,1,1,1] -> все элементы равны


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

double[] array = RandomArray(N, M, T);

Console.WriteLine($"Массив из {T} случайных вещественных чисел от {N} до {M}: [ " + String.Join("  ",array) + " ]");



void Sorting(double[] array)
{

for (int i = 0; i < array.Length - 1; i = i + 3)
{
  
double A = array[i + 1];

double B = array[i];

double C = array[i + 2];

if(A == B && A == C) Console.WriteLine("Все числа массива равны.");

else 
    if(B < A && A < C) Console.WriteLine("Числа массива возврастают");

    else if(B > A && A > C) Console.WriteLine("Числа массива убывают");

    else Console.WriteLine("Числа массива расположены хаотично");
}
}
Sorting(array);





