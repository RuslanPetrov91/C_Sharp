// Напишите программу, которая принимает на вход пятизначное число (N) и проверяет, является ли число палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

int ReadInt(string message)
{
    Console.Write($"{message} > ");
    int value = int.Parse(Console.ReadLine());
    return value;
}

int Reverse(int number)
{
    int reverse = 0;
    while (number > 0)
    {
        reverse = reverse * 10 + number % 10;
        number /= 10;
    }

    return reverse;
}

int number = ReadInt("Введите число >");

int reverse = Reverse(number);

if (reverse == number)
{
    System.Console.WriteLine($"{number} является палиндромом");
}
else
{
    System.Console.WriteLine($"{number} не является палиндромом");
}