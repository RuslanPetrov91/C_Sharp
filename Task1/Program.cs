// Напишите программу, которая на вход принимает 2 числа и проверяет
// является ли второе число квадратом первого.

Console.Write("Введите число 1 => ");                                      // Вывод приглашения на экран
string inputedString1 = Console.ReadLine();                                // Ввод пользователя (строка)
int number1 = Convert.ToInt32(inputedString1);                             // Преобразования строки в число
Console.Write("Введите число 2 => ");                                      // Вывод приглашения на экран
string inputedString2 = Console.ReadLine();                                // Ввод пользователя (строка)
int number2 = Convert.ToInt32(inputedString2);                             // Преобразования строки в число

int square = number2 / number1;

if(square == number1)
{
    Console.WriteLine($"Число {number2} является квадратом {number1}");
}
else
{
    Console.WriteLine($"Число {number2} не является квадратом {number1}");
}