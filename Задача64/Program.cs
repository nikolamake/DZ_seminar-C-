// Задача 64: Задайте значения N и M. Напишите программу, которая выведет все чётные натуральные числа в 
// промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> 2, 4
// M = 4; N = 8 -> 4, 6, 8


Console.Clear();

Console.WriteLine("Введите начальное значение M : ");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите конечное значение N : ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine($"Четные натуральные числа от {M} до {N} :");

Recurs(M,N);

void Recurs(int initial, int final)
{
    if (initial > final) return;
        if (initial % 2 == 0)
        {
            Console.Write(" " + initial);
            Recurs(initial + 1, final);
        }
        else Recurs(initial + 1, final);
}