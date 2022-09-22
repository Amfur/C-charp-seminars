Console.WriteLine("Массив на сколько элементов создать?");
int size = Convert.ToInt32(Console.ReadLine());
int[] natureNum = new int[size];
int start = 1, finish = 1000, diff = 0, max = 0, min = 0;
for(int index = 0; index < size; index++)
{
    natureNum[index] = new Random().Next(start, finish);
    if (index == 0)
    {
        min = natureNum[index];
        max = natureNum[index];
    }
    else
    {
        if (min > natureNum[index]) min = natureNum[index];
        if (max < natureNum[index]) max = natureNum[index];
    }
    Console.WriteLine(natureNum[index]);
}
diff = max - min;
Console.WriteLine("Разница между максимальным и минимальным элементом массива: " + diff);