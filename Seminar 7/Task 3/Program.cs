Random rnd = new Random();
int m = rnd.Next(2, 5);
int n = rnd.Next(2, 5);
int[,] twoArray = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        twoArray[i, j] = rnd.Next(1, 10);
        Console.Write(twoArray[i, j] + " ");
    }
    Console.WriteLine();
}

double avg = 0;
Console.Write("Среднее арифметическое каждого столбца: ");
for (int k = 0; k < twoArray.GetLength(1); k++)
{

    for (int l = 0; l < twoArray.GetLength(0); l++)
    {
        avg += twoArray[l, k];
    }
    avg = avg / twoArray.GetLength(0);
    
    if (k == twoArray.GetLength(1) - 1) // if/else для красивой расстановки знаков препинания
    {
        Console.Write(Math.Round(avg, 1) + ".");
    }
    else
    {
        Console.Write(Math.Round(avg, 1) + ", ");
    }
    
    avg = 0;
}