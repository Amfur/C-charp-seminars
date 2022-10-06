Console.Write("Задайте размерность массива m x n\nm: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] twoDimArray = new double[m, n];
Random rnd = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        twoDimArray[i, j] = rnd.NextDouble() + rnd.Next(-10, 10);
        Console.Write(Math.Round(twoDimArray[i, j], 1) + " ");
    }
    Console.WriteLine();
}