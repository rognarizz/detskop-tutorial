class Program
{
    static void Main()
    {
        int[] CreateArrayRndInt(int size, int min, int max)
        {
            int[] array = new int[size];
            Random rnd = new Random();

            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(min, max);
            }

            return array;
        }

        void PrintArray(int[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length - 1)
                {
                    Console.Write($"{array[i]}, ");
                }
                else
                {
                    Console.Write($"{array[i]}");
                }
            }
            Console.Write("]");
        }


        int CountEvenNumbers(int[] array)
        {
            int count = 0;
            // реализация
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    count++;
                }
            }

            return count;
        }


        int[] arr = CreateArrayRndInt(4, 100, 500);
        PrintArray(arr);

        int countEven = CountEvenNumbers(arr);
        Console.WriteLine($" => {countEven}");
    }
}
