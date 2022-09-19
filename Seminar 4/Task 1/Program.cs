Console.WriteLine("Введите число A:");
double A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите натуральное число B:");
int B = Convert.ToInt32(Console.ReadLine());
double invol = A;
if (0 < B)
{
    for(int mult = 1; mult < B; mult++)
    {
        invol *= A;
    }
    Console.WriteLine("A в степени B = " + invol);
}
else
{
    Console.WriteLine("Введёное число B не является натуральным");
}