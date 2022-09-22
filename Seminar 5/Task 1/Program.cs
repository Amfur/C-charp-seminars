Console.WriteLine("Массив на сколько элементов создать?");
int size = Convert.ToInt32(Console.ReadLine());
int[] threeDigit = new int[size];
int start = 100, finish = 1000, evenNumbers = 0;
for(int index = 0; index < size; index++)
{
    threeDigit[index] = new Random().Next(start, finish);
    if (threeDigit[index]%2 == 0) evenNumbers++;
    Console.WriteLine(threeDigit[index]);
}
Console.WriteLine("Колличество чётных чисел в массиве: " + evenNumbers);