//Задача 2: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

int ReadInt(string message)
{
    Console.Write($"{message} > ");
    int value = int.Parse(Console.ReadLine());
    return value;
}

bool VaidateCords(int x)
{
    if (x <= 0 || x > 4)
    {
        System.Console.WriteLine("Нет такой четверти");
        return false;
    }
    return true;
}

int CheckQuarter(int x)
{
    if (x == 1)
    {
        System.Console.WriteLine($"Значение x > 0, y > 0");
        return 1;
    }
    if (x == 2)
    {
        System.Console.WriteLine($"Значение x < 0, y > 0");
        return 2;
    }
    if (x == 3)
    {
        System.Console.WriteLine($"Значение x < 0, y < 0");
        return 3;
    }
    System.Console.WriteLine($"Значение x > 0, y < 0");
    return 4;
}


int x = ReadInt("Введите номер четверти");
if (VaidateCords(x))
{
    int quarterValue = CheckQuarter(x);
}