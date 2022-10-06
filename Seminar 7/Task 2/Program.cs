//  Создание массива случайной размерности и наполнение его случайными целыми числами от -99 до 99
Random rnd = new Random();
int a = rnd.Next(2, 5);
int b = rnd.Next(2, 5);
int[,] exampleArray = new int[a, b];
for (int i = 0; i < exampleArray.GetLength(0); i++)
{
    for (int j = 0; j < exampleArray.GetLength(1); j++)
    {
        exampleArray[i, j] = rnd.Next(-99, 100);
        Console.Write(exampleArray[i, j] + " ");
    }
    Console.WriteLine();
}
//  Ввод номера строки и стобца. Поиск значения указанного элемента.
//  Т.к в повседневной жизни никто не говорит "нулевой столбец" или "нулевая строка"
//  нумерацию решил сделать с единицы
Console.Write("Введите номера строки и столбца нужного элемента массива\nСтрока: ");
int str = Convert.ToInt32(Console.ReadLine());
Console.Write("Столбец: ");
int col = Convert.ToInt32(Console.ReadLine());

if (str < 1 || str > exampleArray.GetLength(0) ||
    col < 1 || col > exampleArray.GetLength(1))
{
    Console.WriteLine("В массиве нет элемента с указанными индексами");
}
else
{
    Console.WriteLine(exampleArray[str - 1, col - 1]);
}