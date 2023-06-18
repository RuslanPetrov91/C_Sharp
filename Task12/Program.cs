// Напишите программу, которая выводит случайное число из отрезка [10, 9999] и показывает наибольшую цифру числа.
//7812 -> 8 
//1213-> 3 
//845 -> 8

int temp = new Random().Next(10, 9999);
System.Console.WriteLine(temp);

int max = 0;

while (temp > 0)
{
    if (temp % 10 > max)
    {
        max = temp % 10;
    }
    temp = temp / 10;
}
System.Console.WriteLine(max);