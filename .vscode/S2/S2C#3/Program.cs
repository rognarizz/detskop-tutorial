Console.WriteLine("Input your two digit number: ");
int twoDigitnum = Convert.ToInt32(Console.ReadLine());

int firstDigit = twoDigitnum / 10;
int secondDigit = twoDigitnum % 10;

if (twoDigitnum >= 10 && twoDigitnum <= 99)
{
    if (firstDigit > secondDigit)
    {
        Console.WriteLine(firstDigit);
    }
    else
    {
    Console.WriteLine(secondDigit);
    }  

    
}
else
{
    Console.WriteLine("This is not two digit number!");
}
