using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Input your fraction numbers separated by spaces: ");
        string input = Console.ReadLine(); // Эта строка нужна для получения ввода

        double[] convert_ToDouble(string inpValue) // конвертация массива в числа с дробной частью
        {
            string[] numbers = inpValue.Split(' ');
            double[] arrValue = new double[numbers.Length];
            for (int i = 0; i < arrValue.Length; i++)
            {
                arrValue[i] = Convert.ToDouble(numbers[i]); // преобразуем строку в целое число с дробной частью
            }
            return arrValue;
        }

        double[] arr = convert_ToDouble(input);
        double min = arr.Min();
        double max = arr.Max();
        double difference = max - min;

        Console.WriteLine($"Difference between maximum and minimum values: {difference}");
    }
}
