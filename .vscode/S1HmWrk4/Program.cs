Console.WriteLine("Введите целое число от 1 и выше: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= num)
{
    Console.WriteLine(count + " ");
    count = count + 2;
}
