// Задача 68: Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) 
// этих чисел с помощью рекурсии.
// M = 28; N = 7 -> 7

Console.Clear();

Console.WriteLine("Введите начальное значение M : ");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите конечное значение N : ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine($"Наибольшим общим делителем чисел {M} и {N} является число: {NOD(M, N)}");

int NOD(int initial, int final)
{
    if (final == 0)
    {
        return initial;

    }
    return NOD(final, initial % final);
}