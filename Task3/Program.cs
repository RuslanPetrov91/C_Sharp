string[] week = { "Понедельник", "Вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };

Console.Write("Введите номер дня недели: ");
string weekday = Console.ReadLine();                                // Ввод пользователя (строка)
int dayNumber = Convert.ToInt32(weekday);
if (dayNumber < 0 || dayNumber > 7)
{
    Console.WriteLine("Нет такого дня недели!");
}
else
{
    Console.WriteLine(week[dayNumber - 1]);
}