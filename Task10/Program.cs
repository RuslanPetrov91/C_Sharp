// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//78 -> 8 
//12-> 2

int temp = new Random().Next(10, 99);

System.Console.WriteLine(temp);

int number1 = temp % 10;
int number2 = temp / 10;

if (number1 > number2)
{
    System.Console.WriteLine($"{number1}");
}
else
{
    System.Console.WriteLine($"{number2}");
}