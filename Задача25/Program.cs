// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

Console.WriteLine("Введите число A: ");

int A = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B: ");

int B = int.Parse(Console.ReadLine());


int NumberPower(int num1, int num2)
{
int result = num1;

    for (int i = 2; i <= num2; i++)

    {
        result = result * num1;
    }

    return result;
}

Console.WriteLine($"Число {A} в степени {B} равняется {NumberPower(A, B)}");
