Console.WriteLine("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите кол-во столбцов: ");
int collums = int.Parse(Console.ReadLine());

int[,] array = new int[rows, collums];

InputRand(array);
AverageMas(array);

void AverageMas(int[,] array)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        Console.WriteLine($"Среднее арифметическое {i + 1} столбца: {Math.Round(sum / array.GetLength(0), 2)}");
        sum = 0;
    }
}

void ShowArray(int[,] array)
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

void InputRand(int[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rand.Next(0, 10);
    ShowArray(array);
}
