Console.WriteLine("Массив на сколько 'интересных' чисел создать?");
int size = Convert.ToInt32(Console.ReadLine());
int[] interesNums = new int[size];
int ProdDigits(int number)
{
    int product = 1;
    int digit = 0;
    while(number != 0)
    {
        digit = number % 10;
        product *= digit;
        number = number / 10;
    }
    if (product < 0) product = product * -1;
    return product;
}
int SumDigits(int num)
{
    int sum = 0;
    int dig = 0;
    while(num !=0)
    {
        dig = num % 10;
        if (dig < 0) dig = dig * -1;
        sum += dig;
        num = num / 10;
    }

    return sum;
}
int randomNum;
int index = 0;
while(index < size)
{
    randomNum = new Random().Next(-2147483648, 2147483647);
    if (ProdDigits(randomNum) % SumDigits(randomNum) == 0) //Для исключения чисел содержащих в своих разрядах нули, можно ввести условие: "ProdDigits(randomNum) != 0 && ..."
    {
        
        interesNums[index] = randomNum;
        Console.WriteLine($"{ProdDigits(randomNum)}, {SumDigits(randomNum)}: {interesNums[index]}");
        index ++;
    }
}
