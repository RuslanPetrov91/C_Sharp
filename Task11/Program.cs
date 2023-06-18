//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно


System.Console.WriteLine("Введите первое число ");
string NumberOne = Console.ReadLine();
int OneNumber = Convert.ToInt32(NumberOne);
System.Console.WriteLine("Введите второе число ");
string NumberTwo = Console.ReadLine();
int TwoNumber = Convert.ToInt32(NumberTwo);
int value = OneNumber % TwoNumber;
if (value == 0)
{
    System.Console.WriteLine($"кратно ");

}
else
{
    System.Console.WriteLine($"Не кратно, остаток {value}");
}