// Напишите программу, которая будет выдавать код по дням недели

Console.Write("Напишите день недели в виде числа ");                        // Вывод приглашения на экран
string inputedString1 = Console.ReadLine();                                 // Ввод пользователя (строка)
int number1 = Convert.ToInt32(inputedString1);                              // Преобразования строки в число
int n = 7;

if(number1 == 1)
{
    Console.WriteLine($"{number1} - понедельник");
}
if(number1 == 2)
{
    Console.WriteLine($"{number1} - вторник");
}
if(number1 == 3)
{
    Console.WriteLine($"{number1} - среда");
}
if(number1 == 4)
{
    Console.WriteLine($"{number1} - четверг");
}
if(number1 == 5)
{
    Console.WriteLine($"{number1} - пятница");
}
if(number1 == 6)
{
    Console.WriteLine($"{number1} - суббота");
}
if(number1 == 7)
{
    Console.WriteLine($"{number1} - воскресенье");
}
else
{
     Console.WriteLine($"Не тот день");
}