Console.WriteLine("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите кол-во столбцов: ");
int collums = int.Parse(Console.ReadLine());

double[,] array = new double[rows, collums];

InputRand(array);
ShowArray(array);

void ShowArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        Console.Write(array[i,j] + " ");
        }
    Console.WriteLine();
    }
    Console.WriteLine();
}

void InputRand(double[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(rand.Next(0, 10) + rand.NextDouble(), 2);
        }
    ShowArray(array);
}