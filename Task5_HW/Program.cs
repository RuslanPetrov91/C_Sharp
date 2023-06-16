// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите число 1 => ");                                      // Вывод приглашения на экран
string inputedString1 = Console.ReadLine();                                // Ввод пользователя (строка)
int number1 = Convert.ToInt32(inputedString1);                             // Преобразования строки в число
Console.Write("Введите число 2 => ");                                      // Вывод приглашения на экран
string inputedString2 = Console.ReadLine();                                // Ввод пользователя (строка)
int number2 = Convert.ToInt32(inputedString2);

if (number1 > number2)
{
    Console.WriteLine($"max = {number1}, min = {number2}");
}
else
{
    Console.Write($"max = {number2}, min = {number1}");
}