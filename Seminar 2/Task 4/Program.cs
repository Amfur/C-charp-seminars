int start = 1, finish = 1000000;
int randomNumber = new Random().Next(start, finish + 1);
Console.WriteLine(randomNumber);
if (randomNumber % 7 == 0 && randomNumber % 23 == 0)
{
    Console.WriteLine("Сгенерированное число одновременно кратно 7 и 23");
}
else
{
    Console.WriteLine("Сгенерированное число не является одновременно кратным 7 и 23");
}