Console.WriteLine("Задайте размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] nums = new int[size];
for(int i = 0; i < size; i++)
{
    Console.WriteLine($"Задайте {i+1}-й элемент массива");
    nums[i] = Convert.ToInt32(Console.ReadLine()); //new Random().Next(1,10);
    //Console.WriteLine(nums[i]);
}
int sum = 0;
for(int index = 0; index < size / 2; index++)
{
    sum = sum + nums[index] * nums[size-1-index];
}
Console.WriteLine($"Сумма произведений пар чисел заданного массива равна {sum}");