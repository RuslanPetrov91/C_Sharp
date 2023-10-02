// Задача 1: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GenerateArray(int len, int min, int max)              // Создает и наполняет массив
{
    int[] list1 = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < list1.Length; i++)
    {
        list1[i] = rnd.Next(min, max + 1);
    }
    return list1;
}

int SearcheEven(int[] array)                                // Ищет кол-во четных чисел в массиве
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            sum++;
        }
    }
    return sum;
}

void PrintArrey(int[] Arrey)                                // Показывает в терминале массив
{
    for (int i = 0; i < Arrey.Length; i++)
    {
        System.Console.Write(Arrey[i] + " ");
    }
    System.Console.WriteLine();
}

int[] numberlist = GenerateArray(5, 100, 1000);

PrintArrey(numberlist);
System.Console.WriteLine($"Количество чётных чисел в массиве {SearcheEven(numberlist)}");