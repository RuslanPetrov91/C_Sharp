// Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что третьей цифры
// нет. Не использовать строки для расчета
// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 1

int ReadInt(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

bool Minimum3sign(int number)
{
    if (number > 100)
    {
        return true;
    }

    System.Console.WriteLine("третьей цифры нет");
    return false;
}

int temp = ReadInt("Введите число -> ");
int value = 0;
if (Minimum3sign(temp))
{
    while (temp >= 100)
    {
        value = temp % 10;
        temp = temp / 10;
    }
    System.Console.WriteLine(value);
}