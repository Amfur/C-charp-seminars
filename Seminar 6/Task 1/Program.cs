Console.WriteLine("Введите натуральное число:");
int M = Convert.ToInt32(Console.ReadLine());
if(M <= 0)
{
    Console.WriteLine("Введено ненатуральное число!");
}
else
{
    int positiveNum = 0;
    int tmp;
    for(int num = 1; num <= M; num++)
    {
        Console.WriteLine("Введите " + num + "-е число:");
        tmp = Convert.ToInt32(Console.ReadLine());
        if(tmp > 0)
        {
            positiveNum++;
        }
    }
    Console.WriteLine("Введено чисел больше 0: " + positiveNum);
}
