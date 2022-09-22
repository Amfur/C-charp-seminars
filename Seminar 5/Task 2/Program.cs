Console.WriteLine("Массив на сколько элементов создать?");
int size = Convert.ToInt32(Console.ReadLine());
int[] randomNumbers = new int[size];
int start = 0, finish = 100, sumEvenNums = 0;
for(int index = 0; index < size; index++)
{
    randomNumbers[index] = new Random().Next(start, finish);
    if (randomNumbers[index] % 2 == 0 && (index == 0 || index % 2 != 0)) sumEvenNums = sumEvenNums + randomNumbers[index];
    Console.WriteLine(randomNumbers[index]);
}
Console.WriteLine("Сумма чётных элементов с нечётными индексами: " + sumEvenNums);