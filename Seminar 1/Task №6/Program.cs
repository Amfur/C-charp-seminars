int num = 0;
Console.WriteLine("Введите число для проверки его чётности: ");
num = Convert.ToInt32(Console.ReadLine());
if(num %2 == 0)
{
    Console.WriteLine ("Введено чётное число");
}
else
{
    Console.WriteLine ("Введено нечётное число");
}