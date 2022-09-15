int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (0 < N && N < 10)
{
    int[] cube = new int[N];
    for (int count = 1; count <= N; count++)
    {
        cube[count-1] = count*count*count;
        Console.WriteLine(cube[count-1]);
    }
}
else
{
    Console.WriteLine("Введено ненатуральное число");
}
