Console.WriteLine("Input your numeber for X coordinate: ");
int numX = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input your numeber for Y coordinate: ");
int numY = Convert.ToInt32(Console.ReadLine());

if (numX > 0 && numY > 0)
{
    Console.WriteLine("Your number is in plane number 1");
}

if (numX < 0 && numY > 0)
{
    Console.WriteLine("Your number is in plane number 2");
}

if (numX < 0 && numY < 0)
{
    Console.WriteLine("Your number is in plane number 3");
}

if (numX > 0 && numY < 0)
{
    Console.WriteLine("Your number is in plane number 4");
}

if (numX == 0 && numY == 0)
{
    Console.WriteLine("Please, introduce another numbers!");
}