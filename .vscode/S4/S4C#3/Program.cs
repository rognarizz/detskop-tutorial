using System;
using System.Linq;

class Program
{
    static void Main()
    {
        
        // int[] simpleValue = {1, 3, 5, 6, 7, 8};
        // Array.Reverse(simpleValue);
        // Console.WriteLine("Your sorted integers: [" + string.Join (", ", simpleValue) + "]");

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

        int[] arr = Convert_ToInt(input); // вызов функции Convert_ToInt и присваивание значений массиву arr

        Array.Reverse(arr); // меняет его порядок на убывающий

        Console.WriteLine("Your sorted integers: [" + string.Join (", ", arr) + "]");
    }
}
