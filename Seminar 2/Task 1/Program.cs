int start = 100, finish = 999;
int randomNumber = new Random().Next(start, finish + 1);    //создано случайное трёхзначное число
int secondDigit = randomNumber%100/10;
Console.WriteLine(randomNumber);
Console.Write(secondDigit);