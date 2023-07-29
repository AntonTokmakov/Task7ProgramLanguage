Console.WriteLine("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите кол-во столбцов: ");
int collums = int.Parse(Console.ReadLine());

double[,] array = new double[rows, collums];

InputRand(array);
ShowItemUser(array);

void ShowItemUser(double[,] array)
{
    Console.WriteLine("Введите строку массива: ");
    int rowsUser = int.Parse(Console.ReadLine()) - 1;

    Console.WriteLine("Введите кол-во столбцов: ");
    int collumsUser = int.Parse(Console.ReadLine()) - 1;

    if (rowsUser > 0
       && rowsUser <= array.GetLength(0)
       && collumsUser > 0
       && collumsUser <= array.GetLength(1))
    {
        Console.WriteLine("Значение данного элемента: " + array[rowsUser, collumsUser]);
    }
}

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
            array[i, j] = rand.Next(0, 10);
    ShowArray(array);
}
