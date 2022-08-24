int N = -181, even_num = 2;
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
    Console.Write("\n");
}
else
{
    Console.WriteLine("\nМежду введёным числом и 1 отсутствуют чётные числа");
}