int N = 0, even_num = 2;
Console.WriteLine("Введите число:");
N = Convert.ToInt32(Console.ReadLine());
if (N > 1)
{
    while (even_num <= N)
    {
        if (even_num == 2)
        {
            Console.Write("\n" + even_num);
        }
        else
        {
            Console.Write(" " + even_num);
        }
        even_num = even_num + 2;
    }
}
else if (N < 1)
{
    even_num = 0;
    while (even_num >= N)
    {
        if (even_num == 0)
        {
            Console.Write("\n" + even_num);
        }
        else
        {
            Console.Write(" " + even_num);
        }
        even_num = even_num - 2;
    }
}
else
{
    Console.WriteLine("Между 1 и 1 нет чётных числел");
}