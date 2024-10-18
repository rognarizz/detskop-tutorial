Console.WriteLine("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= -9 && num <= 9)
{
    int firstDigit = num;
    Console.WriteLine(firstDigit);
}

else if (num >= 10 && num <= 99)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    Console.WriteLine(firstDigit + ", " + secondDigit);
}

else if (num >= 100 && num <= 999)
{
    int firstDigit = num / 100;
    int secondDigit = (num / 10) % 10;
    int lastDigit = num % 10;
    Console.WriteLine(firstDigit + ", " + secondDigit + ", " + lastDigit);
}

else if (num >= 1000 && num <= 9999)
{
    int firstDigit = (num / 1000) % 10;
    int secondDigit = (num / 100) % 10;
    int thirdDigit = (num / 10) % 10;
    int lastDigit = num % 10;
    Console.WriteLine(firstDigit + ", " + secondDigit + ", " + thirdDigit + ", " + lastDigit);
}

else if (num >= -99 && num <= 0)
{
    int firstDigit = num / 10;
    int secondDigit = (num % 10) * -1;
    Console.WriteLine(firstDigit + ", " + secondDigit);
}

else if (num >= -999 && num <= -100)
{
    int firstDigit = num / 100;
    int secondDigit = ((num / 10) % 10) * -1;
    int lastDigit = (num % 10) * -1;
    Console.WriteLine(firstDigit + ", " + secondDigit + ", " + lastDigit);
}

else if (num >= -9999 && num <= -1000)
{
    int firstDigit = (num / 1000) % 10;
    int secondDigit = ((num / 100) % 10) * -1;
    int thirdDigit = ((num / 10) % 10) * -1;
    int lastDigit = (num % 10) * -1;
    Console.WriteLine(firstDigit + ", " + secondDigit + ", " + thirdDigit + ", " + lastDigit);
}