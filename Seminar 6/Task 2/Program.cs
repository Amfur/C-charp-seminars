Console.WriteLine("Введите коэффициенты прямых в следующем порядке: k1, b1, k2, b2");
double[] coefLines = new double[4];
double x, y;
for (int i = 0; i < coefLines.Length; i++)
{
    coefLines[i] = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine($"Заданы прямые:\ny = {coefLines[0]}x + {coefLines[1]}\ny = {coefLines[2]}x + {coefLines[3]}");
if (coefLines[0] - coefLines[2] == 0 && coefLines[1] - coefLines[3] == 0)
{
    Console.WriteLine("Прямые совпадают");
}
else if(coefLines[0] - coefLines[2] == 0)
{
    Console.WriteLine("Прямые параллельны");
}
else
{
    x = (coefLines[3] - coefLines[1]) / (coefLines[0] - coefLines[2]);
    y = coefLines[0] * x + coefLines[1];
    Console.WriteLine($"Координаты точки пересечения прямых ({x};{y})");
}