// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

//Console.Write("Введите по очереди любое количество чисел одной строкой через пробел: ");
//int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

int GetNumber(string message)
{
int result = 0;
while (true)
{
    Console.WriteLine(message);
    if (int.TryParse(Console.ReadLine(), out result) && result > 0)
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

int [] InitArray(int demensions)
{
    int [] result = new int[demensions];
 //   Console.WriteLine("Введите количество чисел, которые планируете ввести");
   // demensions = Convert.ToInt32(Console.ReadLine()??"");
    for (int i = 0; i < demensions; i++)
    {
        Console.WriteLine("Введите число: ");
        result[i] = Convert.ToInt32(Console.ReadLine()??"");
    }

    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }

    Console.WriteLine();
}

int CheckPositiveNumber(int [] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

//Console.WriteLine("Введите количество чисел, которые планируете ввести");
///int demensions = Convert.ToInt32(Console.ReadLine()??"");
int demensions = GetNumber("Введите количество чисел, которые планируете ввести");
int[] arr = InitArray(demensions);
PrintArray(arr);
int countPositiveNumber = CheckPositiveNumber(arr);
Console.WriteLine($"Количество чисел больше нуля = {countPositiveNumber}");