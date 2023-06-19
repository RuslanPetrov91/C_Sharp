// Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным
// 6-> да
// 7-> да
// 1-> нет

int ReadInt(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

bool Validate3sign(int number)
{
    if (number >= 1 && number <= 7)
    {
        return true;
    }

    System.Console.WriteLine("Число введено неверно");
    return false;
}

int num = ReadInt("Введите номер дня недели > ");
if (Validate3sign(num))
{
    if(num >= 1 && num <= 5)
    {
    System.Console.WriteLine($"будний");
    }
    else
    {
        System.Console.WriteLine("выходной");
    }
}