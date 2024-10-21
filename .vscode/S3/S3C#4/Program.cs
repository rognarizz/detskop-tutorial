using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Input your integer numbers: ");
        string input = Console.ReadLine();

        int[] Convert_ToInt(string inpValue)
        {
            string[] numbers = inpValue.Split(' ');
            int[] arrValue = new int[numbers.Length];
            for (int i = 0; i < arrValue.Length; i++)
            {
                arrValue[i] = Convert.ToInt32(numbers[i]);
            }
            return arrValue;
        }

        int[] arr = Convert_ToInt(input);

        Array.Sort(arr);
        Array.Reverse(arr);

        Console.WriteLine("Your sorted integers: [" + string.Join (", ", arr) + "]");
    }
}
