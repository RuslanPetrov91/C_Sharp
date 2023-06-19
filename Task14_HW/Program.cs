// Напишите программу, которая принимает на
// вход трехзначное число и на выходе показывает вторую
// цифру этого числа. Не использовать строки для расчета

// 456 -> 5
// 782 -> 8
// 918 -> 1

int ReadInt(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

bool Validate3sign(int number)
{
    if (number >= 100 && number < 1000)
    {
        return true;
    }

    System.Console.WriteLine("Число не трехзначное");
    return false;
}

int num = ReadInt("Введите трехзначное число -> ");
if (Validate3sign(num))
{
int value = num / 10 % 10;
System.Console.WriteLine($"{value}");
}