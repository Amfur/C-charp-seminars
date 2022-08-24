int num1 = 0, num2 = 0, max = 0;
Console.WriteLine("Введите первое число:");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
num2 = Convert.ToInt32(Console.ReadLine());
if (num1 >= num2 )
{
    max = num1;
}
else
{
    max = num2;
}
Console.Write("Максимальным из введёных чисел является: " + max);