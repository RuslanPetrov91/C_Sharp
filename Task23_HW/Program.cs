// Напишите программу, 
// которая принимает на вход пятизначное число (N) 
// и проверяет, является ли число палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

int ReadInt(string message)
{
    Console.Write($"{message} > ");
    int value = int.Parse(Console.ReadLine());
    return value;
}

bool Validate5sign(int number)
{
    if (number >= 10000 && number <= 99999)
    {
        return true;
    }

    System.Console.WriteLine("Введено не пятизначное число");
    return false;
}

bool CheckIn(int number)
{
    if (number / 10000 % 10 == number % 10 && number / 1000 % 10 == number / 10 % 10)
    {
        return true;
    }

    System.Console.WriteLine("Это не палиндром");
    return false;
}

int number = ReadInt("Введите целое положительное число >");

if (Validate5sign(number))
{
    if (CheckIn (number))
    {
        System.Console.WriteLine("Это палиндром");
    }
}