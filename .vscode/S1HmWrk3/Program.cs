using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        if (number > 0)
        {
            Console.WriteLine("Число положительное.");
        }
        else if (number < 0)
        {
            Console.WriteLine("Число отрицательное.");
        }
        else
        {
            Console.WriteLine("Число равно нулю.");
        }
    }
}
    