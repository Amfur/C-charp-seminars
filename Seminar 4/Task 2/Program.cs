Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int tempNum = num;
int digit;
int sum = 0;
while (tempNum % 10 != 0 || tempNum / 1 != 0)
{
    digit = tempNum % 10;
    if (digit != 0 && num%digit == 0)
    {
        sum += digit;
        tempNum = tempNum / 10;
    }
    else
    {
        tempNum = tempNum / 10;
    }
}
if (sum < 0)
{
    sum = sum * -1;
    Console.WriteLine("Сумма цифр введённого числа, являющихся его делителем, равна: " + sum);    
}
else
{
    Console.WriteLine("Сумма цифр введённого числа, являющихся его делителем, равна: " + sum);
}
