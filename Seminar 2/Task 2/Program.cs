int start = 1, finish = 65536;
int randomNumber = new Random().Next(start, finish + 1);
Console.WriteLine(randomNumber);
int thridDigit = randomNumber/100;
if (thridDigit == 0)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine(thridDigit%10);
}