int dayNumber = Convert.ToInt32(Console.ReadLine());
if (0 < dayNumber && dayNumber < 8)
{
    if (dayNumber == 6 || dayNumber == 7)
{
    Console.WriteLine("Выходной");
}
    else
{
    Console.WriteLine("Будний день");
}
}
else
{
    Console.WriteLine("Введённое число не является номером дня недели");
}
