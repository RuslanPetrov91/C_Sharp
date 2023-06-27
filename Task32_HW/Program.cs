// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumNumber(int arg)                      // Определяет сумму числа массива
{
    int sum = 0;
    while (arg > 0)
    {
        sum+=arg % 10;
        arg = arg /10;
    }
    return sum;
}

int redIn(string text)                      //Ввод данных
{
    Console.WriteLine(text);
    string number = Console.ReadLine();
    int number2 = Convert.ToInt32(number);
    return number2;
}

int number2 = redIn($"Введите число");
int c = SumNumber(number2);

Console.WriteLine(c);