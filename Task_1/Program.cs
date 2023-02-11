
Console.WriteLine("Введите число m, количество строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n, количество столбцов");
int n = int.Parse(Console.ReadLine());

double[,] array = new double[m, n];

Console.WriteLine("Массив до перестановки:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

for (int j = 0; j < n; j++)
{
    double temp = array[0, j];
    array[0, j] = array[m - 1, j];
    array[m - 1, j] = temp;
}

Console.WriteLine("Массив после перестановки:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
