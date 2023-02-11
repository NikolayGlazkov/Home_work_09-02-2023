// В прямоугольной матрице найти строку с наименьшей суммой элементов.

Console.WriteLine("Введите число m, количество строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n, количество столбцов");
int n = int.Parse(Console.ReadLine());

double[,] array = new double[m, n]; // двумерный массив


for (int i = 0; i < m; i++) //заполняем массив рандомом
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}



double minSum = double.MaxValue;
int minRow = 0;

for (int i = 0; i < m; i++)
{
    double rowSum = 0;
    for (int j = 0; j < n; j++)
    {
        rowSum += array[i, j];
    }

    if (rowSum < minSum) //
    {
        minSum = rowSum;
        minRow = i;
    }
}

Console.WriteLine("Строка с наименьшей суммой: " + (minRow + 1));