int number = Convert.ToInt32(Console.ReadLine()); // Пользователь вводит число
if (number / 10000 != 0 && number / 100000 == 0) // Проверка числа на пятизначность
{
    if (number/10000 == number%10 && number/1000%10 == number/10%10) // Сравнение 5-го разряда с 1-ым и 4-го со 2-ым
    {
        Console.WriteLine("Палиндром");
    }
    else
    {
        Console.WriteLine("Не палиндром");
    }
}
else
{
    Console.WriteLine("Введено не пятизначное число");
}