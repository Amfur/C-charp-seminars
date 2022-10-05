Console.WriteLine("Задайте размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] nums = new int[size];
Console.WriteLine();
for(int i = 0; i < size; i++)
{
    nums[i] = new Random().Next(1,10);
    Console.WriteLine(nums[i]);
}
int sum = 0;
for(int index = 0; index < size / 2; index++)
{
    sum = sum + nums[index] * nums[size-1-index];
}
Console.WriteLine();
Console.WriteLine($"Сумма произведений пар чисел заданного массива равна {sum}");