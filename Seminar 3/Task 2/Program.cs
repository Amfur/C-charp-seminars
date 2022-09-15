double[] dot1 = new double [3];
double[] dot2 = new double [3];
double distance = 0;
int size = dot1.Length;
Console.WriteLine("Вводите координаты точек в следующем порядке: x1, x2, y1, y2, z1, z2");
for (int index = 0; index < size; index++)
{
    double[] diffScuared = new double [3];
    dot1[index] = Convert.ToDouble(Console.ReadLine());
    dot2[index] = Convert.ToDouble(Console.ReadLine());
    diffScuared[index] = (dot2[index]-dot1[index])*(dot2[index]-dot1[index]);
    distance = distance + diffScuared[index];
}
distance = Math.Sqrt(distance);
Console.WriteLine("Расстояние между двумя точками = " + distance);