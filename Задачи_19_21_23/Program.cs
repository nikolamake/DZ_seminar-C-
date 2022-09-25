//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
 
// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Дополнительная задача (задача со звёздочкой): Напишите программу, 
// которая на вход принимает радиус круга и находит его площадь округленную до целого числа, 
// необходимо вывести максимальную цифру в полученном округлённом значении площади круга.
// 10 -> 4
// 20 -> 7
// 30 -> 8

Console.Clear();

Console.WriteLine("Введите номер задачи: 19, 21, 23, 24");

int task = int.Parse(Console.ReadLine());

if(task == 19)
    {
        Task19();
    }

    else if(task == 21)
    {
        Task21();
    }

    else if(task == 23)
    {
        Task23();
    }

    else
    {
        Task24();
    }

void Task19(){

Console.Clear();

Console.WriteLine("Введите пятизначное число: ");

int number = int.Parse(Console.ReadLine());

if (number/10000 < 1 || number/10000 >= 10)
    {
        Console.WriteLine($"Число {number} не является пятизначным!");
    }
else if(number / 10000 == number % 10 && ((number / 1000) % 10 == (number / 10) % 10))
        
        {
        Console.WriteLine($"Число {number} является палиндромом");   
        }
    else
        {
        Console.WriteLine($"Число {number} не является палиндромом!"); 
        }
}

void Task21(){

Console.Clear();

Console.WriteLine("Введите координату X1 точки А");
double X1 = double.Parse(Console.ReadLine()); 

Console.WriteLine("Введите координату Y1 точки А");
double Y1 = double.Parse(Console.ReadLine()); 

Console.WriteLine("Введите координату Z1 точки А");
double Z1 = double.Parse(Console.ReadLine()); 

Console.WriteLine("Введите координату X2 точки B");
double X2 = double.Parse(Console.ReadLine()); 

Console.WriteLine("Введите координату Y2 точки B");
double Y2 = double.Parse(Console.ReadLine()); 

Console.WriteLine("Введите координату Z2 точки B");
double Z2 = double.Parse(Console.ReadLine()); 

double distance = Math.Sqrt(Math.Pow((X1 - X2), 2) + Math.Pow((Y1 - Y2), 2) + Math.Pow((Z1 - Z2), 2));

Console.WriteLine($"Расстояние между точкой А и точкой В равняется {Math.Round(distance, 2)}");
}

void Task23(){
Console.Clear();

Console.WriteLine("Введите  число: ");

double number = double.Parse(Console.ReadLine());

Console.WriteLine($"Таблица кубов целых чисел от 1 до {number}: ");

if(number > 0)

    for (int i = 1; i <= number; i++)

    {
        double tableCub = Math.Pow(i, 3);
        Console.Write($"{tableCub} ");
    }
else
    for (int i = 1; i >= number; i--)

    {
        double tableCub = Math.Pow(i, 3);
        Console.Write($"{tableCub} ");
    }
}

void Task24(){

Console.Clear();

Console.WriteLine("Введите радиус круга: ");

double radius = double.Parse(Console.ReadLine());

double area = Math.Round(Math.PI * Math.Pow(radius, 2)); //значение площади круга, округленное до целого числа  

int i = 1; // для перемещения по разрядам

double max0 = area % i;

double max = max0;

while (Math.Floor(area / i) % 10 > 1)
    {
        double maxInd = (Math.Floor(area / i) % 10);

        if (maxInd > max) max = maxInd;
  
    i = i * 10;
    }
Console.WriteLine($"Максимальная цифра в значении площади круга равняется {max}");
}










