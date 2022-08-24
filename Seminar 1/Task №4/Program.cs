int num1 = 0, num2 = 0, num3 = 0, max = 0;
Console.WriteLine("Введите первое число:");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
num3 = Convert.ToInt32(Console.ReadLine());
if (num1 >= num2 && num1 >= num3)
{
    max = num1;
}
else
{
    if (num2 >= num3)
    {
        max = num2;
    }
    else
    {
        max = num3;
    }
}
Console.Write("Максимальным, из введёных чисел, является: " + max);