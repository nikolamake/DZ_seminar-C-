// Напишите программу, которая задаёт массив из n элементов, 
// которые необходимо заполнить случайными значениями и сдвинуть элементы массива влево,
//  или вправо на 1 позицию.
// [8, 5, 1, 7, 0] - [5, 1, 7, 0, 8] - сдвиг влево
// [8, 5, 1, 7, 0] - [0, 8, 5, 1, 7] - сдвиг вправо



Console.Clear();

Console.WriteLine("Введите минимальное значение в масиве: ");

int min = int.Parse(Console.ReadLine());

Console.WriteLine("Введите максимальное значение в масиве: ");

int max = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество элементов массива: ");

int total = int.Parse(Console.ReadLine());

int[] array = RandomArray(min, max, total);

int[] newArrayLeft = ShiftArrayLeft(array);

int[] newArrayRight = ShiftArrayRight(array);


int[] RandomArray(int lower, int upper, int quantity) 
{
    int[] random = new int[quantity];

    for (int i = 0; i < quantity; i++)
    {
        random[i] = new Random().Next(lower, upper + 1);
    }

    return random;
}

int[] ShiftArrayLeft(int[] arraySource)
{

    int[] shift = new int[arraySource.Length];

    shift[arraySource.Length - 1] = arraySource[0];

    for (int i = 0; i < arraySource.Length - 1; i++)
    {

        shift[i] = arraySource[i + 1];
    }

    return shift;
}

int[] ShiftArrayRight(int[] arraySource)
{

    int[] shift = new int[arraySource.Length];

    shift[0] = arraySource[arraySource.Length - 1];

    for (int i = 1; i < arraySource.Length ; i++)
    {

        shift[i] = arraySource[i - 1];
    }

    return shift;
}




Console.WriteLine($"Массив из {total} случайных целых чисел от {min} до {max}: [ " + String.Join(", ", array) + " ]");

Console.WriteLine($"Массив при сдвиге влево:                           [ " + String.Join(", ",newArrayLeft) + " ]");

Console.WriteLine($"Массив при сдвиге вправо:                   [ " + String.Join(", ",newArrayRight) + " ]");