Console.WriteLine("Input ten integer numbers separated by spaces: ");

string input = Console.ReadLine(); // Считываем введенную строку и сохраняем её в переменной input
string[] numbers = input.Split(' '); // разделения строки input на массив строк, где каждая строка представляет собой одно число

int[] arr = new int[10]; // Создаем массив arr из десяти элементов типа int
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Convert.ToInt32(numbers[i]); // преобразуем строку в целое число
}

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 20 && arr[i] < 90)
    {
        count++; // считает количество значений что соответствуют этому диапазону
    }
}

Console.WriteLine($"Number of values in the range from 20 to 90: {count}");