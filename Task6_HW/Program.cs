Console.Write("Введите число 1 => ");                                      // Вывод приглашения на экран
string inputedString1 = Console.ReadLine();                                // Ввод пользователя (строка)
int number1 = Convert.ToInt32(inputedString1);                             // Преобразования строки в число
Console.Write("Введите число 2 => ");                                      // Вывод приглашения на экран
string inputedString2 = Console.ReadLine();                                // Ввод пользователя (строка)
int number2 = Convert.ToInt32(inputedString2);
Console.Write("Введите число 3 => ");                                      // Вывод приглашения на экран
string inputedString3 = Console.ReadLine();                                // Ввод пользователя (строка)
int number3 = Convert.ToInt32(inputedString3);

int max = number1;
if (number1 > max) max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;

Console.Write($"{max}");