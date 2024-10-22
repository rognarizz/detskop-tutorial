using System;
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Input your integer numbers: ");
            string input = Console.ReadLine();

            if (input == "q")
            {
                Console.WriteLine("[STOP]");
                break;
            }

            else
            {
                int numInput = Convert.ToInt32(input);
                if (numInput % 2 == 0)
                {
                    Console.WriteLine("[STOP]");
                    break;
                }
            }
        }
    }
}