// Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
// Дополнительная задача 2 (задача со звёздочкой): Напишите программу, которая задаёт массив из n элементов, 
// которые необходимо заполнить случайными значениями и определить существует ли пара соседних элементов с одинаковыми значениями, 
// при наличии такого элемента заменить его на уникакальное значение.
// [1,2,3,3] -> [1,2,3,4]



Console.Clear();

Console.WriteLine("Введите минимальное значение в масиве: ");

int min = int.Parse(Console.ReadLine());

Console.WriteLine("Введите максимальное значение в масиве: ");

int max = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество элементов массива: ");

int total = int.Parse(Console.ReadLine());

int[] array = RandomArray(min, max, total);



int[] RandomArray(int lower, int upper, int quantity)
{
    int[] random = new int[quantity];

    for (int i = 0; i < quantity; i++)
    {
        random[i] = new Random().Next(lower, upper + 1);
    }

    return random;
}

int[] IdenticalPairedElements(int[] sourceArray)
{

    int[] newArray = new int[sourceArray.Length];


    if (sourceArray.Length % 2 != 0)

        for (int i = 0; i < sourceArray.Length; i = i + 2)
        {

            for (int j = 1; j < sourceArray.Length - 1; j = j + 2)
            {
                if ((sourceArray[j] == sourceArray[j - 1]) || (sourceArray[j] == sourceArray[j + 1]))

                    newArray[j] = (sourceArray[j + 1]) + (sourceArray[j - 1]) + i;

                else newArray[j] = sourceArray[j];
            }

            newArray[i] = sourceArray[i];
        }



    else 
    for (int i = 0; i < sourceArray.Length; i = i + 2)

    {

        for (int j = 1; j < sourceArray.Length - 2; j = j + 2)
        {
            if ((sourceArray[j] == sourceArray[j - 1]) || (sourceArray[j] == sourceArray[j + 1]))

                newArray[j] = (sourceArray[j + 1]) + (sourceArray[j - 1]) + i;

            else newArray[j] = sourceArray[j];
        }

        newArray[i] = sourceArray[i];
    if (sourceArray[sourceArray.Length - 1] != sourceArray[sourceArray.Length - 2])
    {
        newArray[sourceArray.Length - 1] = sourceArray[sourceArray.Length - 1];
        newArray[sourceArray.Length - 2] = sourceArray[sourceArray.Length - 2];
    }    
        else
    {
        newArray[sourceArray.Length - 1] = sourceArray[sourceArray.Length - 1] + sourceArray[sourceArray.Length - 1];
        newArray[sourceArray.Length - 2] = sourceArray[sourceArray.Length - 2];
    }

    }

    return newArray;

}






Console.WriteLine($"Массив из {total} случайных целых чисел от {min} до {max}:   [ " + String.Join(", ", array) + " ]");

Console.WriteLine($"Массив без одинаковых стоящих рядом элементов: [ " + String.Join(", ", IdenticalPairedElements(array)) + " ]");