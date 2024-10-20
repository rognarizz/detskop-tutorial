Console.WriteLine("Input your ten integers separated by spaces: ");
string input = Console.ReadLine(); // Эта строка нужна для получения ввода

int[] inpNum(string inpValue) // Здесь нужно указать тип возвращаемого значения как int[]
{
    string[] numbers = inpValue.Split(' ');
    int[] arrValue = new int[10];
    for (int i = 0; i < arrValue.Length; i++)
    {
        arrValue[i] = Convert.ToInt32(numbers[i]); // преобразуем строку в целое число
    }
    return arrValue;
}

int countEvenum = 0;

int[] arr = inpNum(input); // Здесь нужно передать input в метод

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    {
        countEvenum++; // считает количество значений что соответствуют этому диапазону
    }
}


// int count = 0;
// Console.WriteLine($"Among your numbers were found {countEvenum} even numbers.");

// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > 20 && arr[i] < 90)
//     {
//         count++; // считает количество значений что соответствуют этому диапазону
//     }
// }

// Console.WriteLine($"Number of values in the range from 20 to 90: {count}");
