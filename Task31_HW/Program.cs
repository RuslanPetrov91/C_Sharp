// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string message)                                      //Функция возврата TryParse
{
    System.Console.Write($"{message} > ");
    string inputedStr = Console.ReadLine();
    int value;
    if (int.TryParse(inputedStr, out value))
    {
        return value;
    }
    System.Console.WriteLine("Извините, но вы ввели не число");
    Environment.Exit(0);
    return 0;
}

int Exponentiation(int number, int exp)                                     
{
    int power = 1;
    for (int i = 0; i < exp; i++)
    {
        power *= number;
    }

    return power;
}

int powerBase = Prompt("Введите число A");
int exponent = Prompt("Введите число B");

int power = Exponentiation(powerBase, exponent);
System.Console.WriteLine(power);