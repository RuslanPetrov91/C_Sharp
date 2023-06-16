// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все четные числа от 1 до N

Console.Write("Введите число => ");
string inputedString1 = Console.ReadLine();
int number1 = Convert.ToInt32(inputedString1);
int number2 = 1;
int number3 = 2;
while (number2 <= number1)
{
    if (number2 % number3 == 0)
    {
        Console.Write($"{number2} ");
    }
    number2++;
}