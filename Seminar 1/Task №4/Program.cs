int num1 = 10, num2 = 20, num3 = 3, max = 0;
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
Console.Write (max);