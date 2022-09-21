// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

Console.WriteLine("Введите число: ");


int number = int.Parse(Console.ReadLine());

int ratio = 1; // для уменьшения разряда

int n1 = number / (ratio); // целая часть при  переходе разрядов

int N1 = number % (ratio); // остаток при  qantity переходов
if(number > 99 || number < -99)

    if(number > 99)

        {
            while(n1 < 10 || n1 > 999) 
    
            {  
                n1 = number / (ratio);

                ratio = ratio *10;
             }
            N1 = n1 % 10;
     
            Console.WriteLine($"Третья цифра числа {number} ровна {N1} ");
        }
    
    else
        {
            while(n1 > -10 || n1 < -999) 
    
            {  
                n1 = number / (ratio);

                ratio = ratio *10;
            }
            N1 = -n1 % 10;
     
            Console.WriteLine($"Третья цифра числа {number} ровна {N1} ");
        }


else
    Console.WriteLine($"Третья цифра числа {number} отсутствует!");