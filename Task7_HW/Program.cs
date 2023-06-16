Console.Write("Введите число => "); 
string inputedString1 = Console.ReadLine();
int number1 = Convert.ToInt32(inputedString1);   
int number2 = 2;
if (number1 % number2 == 0)
{
    Console.Write("Четное");
}
else
{
    Console.Write("Нечетное");
}