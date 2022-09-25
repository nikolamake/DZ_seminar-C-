// Дополнительная задача (задача со звёздочкой): Напишите программу, 
// которая на вход принимает радиус круга и находит его площадь округленную до целого числа, 
// необходимо вывести максимальную цифру в полученном округлённом значении площади круга.
// 10 -> 4
// 20 -> 7
// 30 -> 8

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

//Console.WriteLine($"Площадь круга радиусом {radius} равна {area}");