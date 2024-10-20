Console.WriteLine("Input your ten integers separated by spaces: ");
string input = Console.ReadLine(); // Эта строка нужна для получения ввода

int[] inpNum(string inpValue) // Здесь нужно указать тип возвращаемого значения как int[]
{
    string input = inpValue;
    string[] numbers = input.Split(' ');

    int[] arr = new int[10];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToInt32(numbers[i]); // преобразуем строку в целое число
    }
    return arr;
}

int count = 0;

int[] arr = inpNum(input); // Здесь нужно передать input в метод

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    {
        count++; // считает количество значений что соответствуют этому диапазону
    }
}

Console.WriteLine($"Among your numbers were found {count} even numbers.");
