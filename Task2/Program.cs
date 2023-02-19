// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int GetNumber(string message)
{
int result = 0;
while (true)
{
    Console.WriteLine(message);
    if (int.TryParse(Console.ReadLine(), out result))
    {
        break;
    }
    else
    {
        Console.WriteLine("Вы ввели некорректное число! Повтороите ввод");
    } 
}
return result;
}

void FindIntersectionPoint(int b1, int k1, int b2, int k2)
{
    if (k1 != k2 && b1 != b2)
    {
    double x = (double) (b2 - b1)/(k1 - k2);
    double y = (double) k1*(b2-b1)/(k1-k2) + b1;
    Console.WriteLine($"Точка пересечения двух прямых ({x} ; {y})");
    Console.WriteLine($"Х: {x:0.00}");
    Console.WriteLine($"Y: {y:0.00}");
    }
    
    else Console.WriteLine("Прямые параллельны или сопадают");
}

int b1 = GetNumber("Введите координату Х первой точки");
int k1 = GetNumber("Введите координату Y первой точки");
int b2 = GetNumber("Введите координату Х второй точки");
int k2 = GetNumber("Введите координату Н второй точки");
Console.Write($"Координаты первой точки:({b1},{k1}) координаты второй точки:({b2},{k2})");
Console.WriteLine();
FindIntersectionPoint (b1, k1, b2, k2);

